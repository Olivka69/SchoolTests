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
    public partial class Form_Teachers : Form
    {
        public Form_Teachers()
        {
            InitializeComponent();
        }

        private void Form_Teachers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter.Fill(this.schooltestDataSet.Specialty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Lecturers". При необходимости она может быть перемещена или удалена.
            this.lecturersTableAdapter.Fill(this.schooltestDataSet.Lecturers);

        }

        //===Обработка нажатия кнопки "Сохранить" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lecturersBindingSource.EndEdit();
            this.lecturersTableAdapter.Update(this.schooltestDataSet.Lecturers);
            MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
