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
    public partial class Form_TestsResults : Form
    {
        public Form_TestsResults()
        {
            InitializeComponent();
        }

        //===Обработка события загрузки формы
        private void Form_TestsResults_Load(object sender, EventArgs e)
        {
            string ID_Specialty = "";                          //ID специальности авторизовавшегося преподавателя

            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Conformity". При необходимости она может быть перемещена или удалена.
            this.conformityTableAdapter.Fill(this.schooltestDataSet.Conformity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Lecturers". При необходимости она может быть перемещена или удалена.
            this.lecturersTableAdapter.Fill(this.schooltestDataSet.Lecturers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Modules". При необходимости она может быть перемещена или удалена.
            this.modulesTableAdapter.Fill(this.schooltestDataSet.Modules);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.schooltestDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Results". При необходимости она может быть перемещена или удалена.
            this.resultsTableAdapter.Fill(this.schooltestDataSet.Results);

            Test_ComboBox.Items.Clear();                         //очистка содержимого перечня доступных тестов

            for (int i = 0; i < Teachers_DataGridView.RowCount - 1; i++)
            {
                if (Convert.ToInt32(Teachers_DataGridView.Rows[i].Cells[0].Value.ToString()) == Form_Auth.Login_Index_Global)
                {
                    ID_Specialty = Teachers_DataGridView.Rows[i].Cells[5].Value.ToString(); //ID специальности
                    break;
                }
            }
            for (int i = 0; i < Tests_DataGridView.RowCount - 1; i++)
            {
                string ID_Discipline = Tests_DataGridView.Rows[i].Cells[2].Value.ToString().Trim(); //Код дисциплины теста
                for (int j = 0; j < Conformity_DataGridView.RowCount - 1; j++)
                {
                    if ((Conformity_DataGridView.Rows[j].Cells[1].Value.ToString() == ID_Specialty) &&
                        (Conformity_DataGridView.Rows[j].Cells[2].Value.ToString() == ID_Discipline))
                    {
                        Test_ComboBox.Items.Add(Tests_DataGridView.Rows[i].Cells[1].Value.ToString().Trim());
                    }
                }
            }
            string serv_str = "0";
            resultsBindingSource.Filter = "ID_module = '" + serv_str + "'";         //скрыть все вопросы

        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        //===Обработка нажатия кнопки "Выбрать"
        private void Choice_Button_Click(object sender, EventArgs e)
        {
            string ID_Test = "";                         //ID выбранного теста
            for (int i = 0; i < Tests_DataGridView.RowCount - 1; i++)
            {
                if (Tests_DataGridView.Rows[i].Cells[1].Value.ToString() == Test_ComboBox.Text)
                {
                    ID_Test = Tests_DataGridView.Rows[i].Cells[0].Value.ToString();
                }
            }
            resultsBindingSource.Filter = "ID_module = '" + ID_Test + "'";
        }
    }
}
