using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTests
{
    public partial class Form_MainStudent : Form
    {
        public Form_MainStudent()
        {
            InitializeComponent();
        }

        public static int Q_Numbers;                           //количество вопросов в тесте
        public static int Q_Curr;                              //номер текущего вопроса
        public static double A_Right;                             //количество правильных ответов
        public static double Perc_Right;                       //процент правильных ответов
        DateTime TimeTest = new DateTime(0, 0);                //Переменная для таймера

        //===Обработка события закрытия формы
        private void Form_MainStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Auth Form_Auth = new Form_Auth();
            Form_Auth.Close();
            Application.Exit();
        }


        //===Функция формирования вопроса
        void Func_FormQuestion(int cq)
        {
            if (Questions_DataGridView.Rows[cq].Cells[3].Value.ToString() != "")   //тип вопроса - одиночный выбор
            {
                Questions_TextBox.Text = Questions_DataGridView.Rows[cq].Cells[1].Value.ToString();
                AnsVar1_RadioButton.Text = Questions_DataGridView.Rows[cq].Cells[2].Value.ToString();
                AnsVar2_RadioButton.Text = Questions_DataGridView.Rows[cq].Cells[3].Value.ToString();
                AnsVar3_RadioButton.Text = Questions_DataGridView.Rows[cq].Cells[4].Value.ToString();
                AnsVar4_RadioButton.Text = Questions_DataGridView.Rows[cq].Cells[5].Value.ToString();
                AnsVar1_RadioButton.Checked = true;               
                AnsVar1_RadioButton.Visible = true;
                AnsVar2_RadioButton.Visible = true;
                AnsVar3_RadioButton.Visible = true;
                AnsVar4_RadioButton.Visible = true;
                Ans_Label.Visible = false;
                Ans_TextBox.Visible = false;
            }
            else                                                                   //тип вопроса - точный ответ
            {
                Questions_TextBox.Text = Questions_DataGridView.Rows[cq].Cells[1].Value.ToString();
                AnsVar1_RadioButton.Visible = false;
                AnsVar2_RadioButton.Visible = false;
                AnsVar3_RadioButton.Visible = false;
                AnsVar4_RadioButton.Visible = false;
                Ans_Label.Visible = true;
                Ans_TextBox.Visible = true;
                Ans_TextBox.Text = "";
            }
        }
        //===Обработка события загрузки формы
        private void Form_MainStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.schooltestDataSet.Results);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Questions". При необходимости она может быть перемещена или удалена.
            this.questionsTableAdapter.Fill(this.schooltestDataSet.Questions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Modules". При необходимости она может быть перемещена или удалена.
            this.modulesTableAdapter.Fill(this.schooltestDataSet.Modules);
            TestStatus_StatusLabel.Text = "Выбор теста";
        }
        
        //===Обработка нажатия кнопки "Начать тест"
        private void TestBegin_Button_Click(object sender, EventArgs e)
        {
            int sel_ind = Test_ComboBox.SelectedIndex;               //выюранный индекс
            string ID_Test = Tests_DataGridView.Rows[sel_ind].Cells[0].Value.ToString();
            questionsBindingSource.Filter = "ID_module = '" + ID_Test + "'";
            Q_Numbers = Questions_DataGridView.RowCount - 1;             //количество вопросов в выбраном тесте

            if (Q_Numbers == 0)
            {
                MessageBox.Show("Выбранный тест еще не сформирован!", "Сообщение об ошибке", MessageBoxButtons.OK);
                return;
            }

            Q_Curr = 0;                                       //первый вопрос
            A_Right = 0;                                      //количество правильных ответов         
            Wait_PictureBox.Visible = false;                  //снятие блока на вопросы и ответы
            Test_ComboBox.Enabled = false;
            TestBegin_Button.Enabled = false;
            ResponceConfirmation_Button.Enabled = true;       //кнопка подтверждения ответа
            TestStatus_StatusLabel.Text = "Прохождение теста";
            TestStudent_StatusLabel.Text = Form_Auth.FIO;
            TestResults_StatusLabel.Text = "Вопрос " + Convert.ToString(Q_Curr + 1) + " из " + Convert.ToString(Q_Numbers);
            Test_Timer.Enabled = true;                        //запуск таймера
            Func_FormQuestion(Q_Curr);                        //формирование очередного вопроса
        }

        //===Обработка нажатия кнопки "Подтверждение ответа"
        private void ResponceConfirmation_Button_Click(object sender, EventArgs e)
        {
            string Answer = "";                          //ответ пользователя

            if (AnsVar1_RadioButton.Visible)               //обработка одиночного выбора 
            {
                if (AnsVar1_RadioButton.Checked)
                {
                    Answer = "1";
                }
                if (AnsVar2_RadioButton.Checked)
                {
                    Answer = "2";
                }
                if (AnsVar3_RadioButton.Checked)
                {
                    Answer = "3";
                }
                if (AnsVar4_RadioButton.Checked)
                {
                    Answer = "4";
                }
            }
            else                //точный ответ
            {
                Answer = Ans_TextBox.Text.ToLower();
            }

            //проверка правильности ответа
            if (Questions_DataGridView.Rows[Q_Curr].Cells[6].Value.ToString().ToLower() == Answer)
            {
                A_Right++;            //увеличивается кол-во правильных ответов
            }
            Q_Curr++;                 //следующий вопрос
            if (Q_Curr < Q_Numbers)   //если тест еще не окончен
            {
                TestResults_StatusLabel.Text = "Вопрос " + Convert.ToString(Q_Curr + 1) + " из " + Convert.ToString(Q_Numbers);
                Func_FormQuestion(Q_Curr);
            }
            else
            {
                //тест завершен
                Test_Timer.Enabled = false;                  //останов таймера
                TimeTest = new DateTime(0, 0);               //сброс времени прохождения
                Perc_Right = (double) (A_Right / Q_Numbers) * 100;    //процент правильных ответов
                MessageBox.Show("Тест завершен! " + "Дано " + Convert.ToString(A_Right) + " правильных ответов " + " из " +
                    Convert.ToString(Q_Numbers) + " возможных (" + Convert.ToString(Perc_Right) + "%).",
                                          "Тестирование окончено", MessageBoxButtons.OK);
                ResponceConfirmation_Button.Enabled = false;
                Save_Button.Enabled = true;
                Exit_Button.Enabled = false;
                TestStatus_StatusLabel.Text = "";
                TestTime_StatusLabel.Text = "";
                TestResults_StatusLabel.Text = "";
                TestStudent_StatusLabel.Text = "";
                TestStatus_StatusLabel.Text = "Запись результатов";
            }
        }
        //===Обработка события срабатывания таймера
        private void Test_Timer_Tick(object sender, EventArgs e)
        {
            TimeTest = TimeTest.AddSeconds(1);
            TestTime_StatusLabel.Text = TimeTest.ToString("mm:ss");
        }

        private void TestStatus_StatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //===Обработка нажатия кнопки "Выход"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //===Обработка нажатия кнопки "Запись результатов"
        private void Save_Button_Click(object sender, EventArgs e)
        {
            //==============создание новой строки в таблице Results
            schooltestDataSet.ResultsRow newResultsRow;
            newResultsRow = schooltestDataSet.Results.NewResultsRow();
            //==============формирование полей новой строки таблицы Results
            newResultsRow.Date_result = DateTime.Now;  //Дата и время сдачи теста
            newResultsRow.ID_student = Form_Auth.Login_Index_Global;  //Код студента
            newResultsRow.ID_module = Convert.ToInt32(Tests_DataGridView.Rows[Test_ComboBox.SelectedIndex].Cells[0].Value.ToString()); //Код модуля
            newResultsRow.Sum_points = Convert.ToInt32(Perc_Right);
            //============добавление созданной строки в таблицу Results
            this.schooltestDataSet.Results.Rows.Add(newResultsRow);
            //==========сохранение созданной строки в БД
            this.resultsTableAdapter.Update(this.schooltestDataSet.Results);
            //======================выдача сообщения
            MessageBox.Show("Результаты теста успешно записаны!", "Операция закончена", MessageBoxButtons.OK);
            Save_Button.Enabled = false;
            Exit_Button.Enabled = true;
            TestBegin_Button.Enabled = true;
            Test_ComboBox.Enabled = true;
            TestStatus_StatusLabel.Text = "";
            TestTime_StatusLabel.Text = "";
            TestResults_StatusLabel.Text = "";
            TestStudent_StatusLabel.Text = "";
            Wait_PictureBox.Visible = true;
            TestStatus_StatusLabel.Text = "Выбор теста";
        }
    }
}
