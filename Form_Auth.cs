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
    public partial class Form_Auth : Form
    {
        public Form_Auth()
        {
            InitializeComponent();
        }

        //===Константы модуля
        public const int Max_Number_Attempt = 5;         //максимальное число попыток входа в систему

        //===Переменные модуля
        public static int Number_Attempt;                //число неправильных попыток входа в систему
        public static int User_Rights;                   //права пользователя: 1 - педагог; 2 - учащийся
        public static int Login_Index_Global;            //Выбранный ID пользователя        
        public static string FIO;                        //ФИО проходящего тест

        //===Обработка события загрузки формы
        private void Form_Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.schooltestDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Lecturers". При необходимости она может быть перемещена или удалена.
            this.lecturersTableAdapter.Fill(this.schooltestDataSet.Lecturers);
            Number_Attempt = 0;                          //сброс количества попыток авторизации   
        }
        //===Обработка изменения значения переключателя "Педагог"
        private void Teacher_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Login_ComboBox.DataSource = lecturersBindingSource;
            Login_ComboBox.DisplayMember = "Login_lecturer";
            Login_ComboBox.ValueMember = "ID_lecturer";
        }
        //===Обработка изменения значения переклюсателя "Учащийся"
        private void Student_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Login_ComboBox.DataSource = studentsBindingSource;
            Login_ComboBox.DisplayMember = "Login_student";
            Login_ComboBox.ValueMember = "ID_student";
        }
        //===Обработка нажатия кнопки "Выход"
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //===Обработка нажатия кнопки "Авторизация" (попытка входа в систему)
        private void Auth_Button_Click(object sender, EventArgs e)
        {
            int LoginForm_ID;                            //ID выбранного логина
            int LoginForm_Index;                         //номер строки выбранного логина
            string PasswordForm;                         //набранный пользователем пароль
            string PasswordDB;                           //пароль из БД
           
            LoginForm_ID = Convert.ToInt32(Login_ComboBox.SelectedValue);        //ID выбранного логина
            LoginForm_Index = Login_ComboBox.SelectedIndex;             //номер строки выбранного логина  
            PasswordForm = Password_TextBox.Text;                       //набранный пользователем пароль

            Login_Index_Global = LoginForm_ID;                          //глобальный ID пользователя

            if (Teacher_RadioButton.Checked)                            //авторизация педагога
            {
                PasswordDB = Lecturers_DataGridView.Rows[LoginForm_Index].Cells[4].Value.ToString().Trim();
                FIO = Lecturers_DataGridView.Rows[LoginForm_Index].Cells[1].Value.ToString().Trim() + " " +
                    Lecturers_DataGridView.Rows[LoginForm_Index].Cells[2].Value.ToString().Trim();
            }
            else                                                        //авторизация учащегося
            {
                PasswordDB = Students_DataGridView.Rows[LoginForm_Index].Cells[5].Value.ToString().Trim();
                FIO = Students_DataGridView.Rows[LoginForm_Index].Cells[1].Value.ToString().Trim() + " " +
                    Students_DataGridView.Rows[LoginForm_Index].Cells[2].Value.ToString().Trim();
            }

            if (PasswordForm != PasswordDB)                             //пароль введен неправильно
            {
                Number_Attempt++;                                       //увеличивается количество неудачных попыток
                if (Number_Attempt == Max_Number_Attempt)               //попыток больше не осталось
                {
                    MessageBox.Show("Превышено кол-во попыток входа в систему. Выход из приложения!", "Сообщение об ошибке", MessageBoxButtons.OK);
                    Application.Exit();                                 //Выход из приложения
                }
                else                                                    //еще есть попытки
                {
                    string mess = "Неверный пароль. Осталось попыток авторизации: " + Convert.ToString(Max_Number_Attempt - Number_Attempt);
                    MessageBox.Show(mess, "Сообщение об ошибке", MessageBoxButtons.OK);
                    Password_TextBox.Text = "";                         //Очистка поля ввода пароля
                }
            }
            else                                                        //пароль введен корректно
            {

                if (Teacher_RadioButton.Checked)                        //вход для педагога 
                {
                    Form_MainTeacher Form_MainTeacher = new Form_MainTeacher();
                    Form_MainTeacher.Show();
                }
                else
                {
                    Form_MainStudent Form_MainStudent = new Form_MainStudent();
                    Form_MainStudent.Show();
                }
                this.Hide();                                            //скрытие формы авторизации
            }
           
        }
    }
}
