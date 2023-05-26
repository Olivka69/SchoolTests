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
    public partial class Form_Conformity : Form
    {
        public Form_Conformity()
        {
            InitializeComponent();
        }

        private void Form_Conformity_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.schooltestDataSet.Disciplines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter.Fill(this.schooltestDataSet.Specialty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Conformity". При необходимости она может быть перемещена или удалена.
            this.conformityTableAdapter.Fill(this.schooltestDataSet.Conformity);

        }
        //===Обработка нажатия кнопки "Сохранить" (попытка записи измкенений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conformityBindingSource.EndEdit();
            this.conformityTableAdapter.Update(this.schooltestDataSet.Conformity);
            MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
