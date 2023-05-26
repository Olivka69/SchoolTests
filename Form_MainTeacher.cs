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
    public partial class Form_MainTeacher : Form
    {
        public Form_MainTeacher()
        {
            InitializeComponent();
        }

        //===Обработка события закрытия формы
        private void Form_MainTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_Auth Form_Auth = new Form_Auth();
            Form_Auth.Close();
            Application.Exit();
        }
        //===Обработка выбора пункта меню "Справочники -> Педагоги"
        private void педагогиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Teachers Form_Teachers = new Form_Teachers();
            Form_Teachers.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Специальности педагогов"
        private void специальностиПедагоговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Specialty Form_Specialty = new Form_Specialty();
            Form_Specialty.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Учащиеся"
        private void учащиесяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Students Form_Students = new Form_Students();
            Form_Students.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Учебные дисциплины"
        private void учебныеДисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Disciplines Form_Disciplines = new Form_Disciplines();
            Form_Disciplines.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Соответствие между специальностями и дисциплинами"
        private void соответствиеМеждуСпециальностямиИДисциплинамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Conformity Form_Conformity = new Form_Conformity();
            Form_Conformity.ShowDialog();
        }
        //===Обработка выбора пункта меню "Справочники -> Темы тестов"
        private void темыТестовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Modules Form_Modules = new Form_Modules();
            Form_Modules.ShowDialog();
        }
        //===Обработка выбора пункта меню "Редактирование тестов"
        private void редактированиеТестовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TestsEdit Form_TestsEdit = new Form_TestsEdit();
            Form_TestsEdit.ShowDialog();
        }
        //===Обработка выбора пункта меню "Просмотр результатов тестов"
        private void просмотрРезультатовТестовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TestsResults Form_TestsResults = new Form_TestsResults();
            Form_TestsResults.ShowDialog();
        }
        //===Обработка выбора пункта меню "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About Form_About = new Form_About();
            Form_About.ShowDialog();
        }

        //===Обработка выбора пункта меню "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
