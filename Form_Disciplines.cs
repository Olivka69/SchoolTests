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
    public partial class Form_Disciplines : Form
    {
        public Form_Disciplines()
        {
            InitializeComponent();
        }

        private void Form_Disciplines_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.schooltestDataSet.Disciplines);

        }

        //===Обработка нажатия кнопки "Сохранить" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.disciplinesBindingSource.EndEdit();
            this.disciplinesTableAdapter.Update(this.schooltestDataSet.Disciplines);
            MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Discipline_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
