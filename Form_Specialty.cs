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
    public partial class Form_Specialty : Form
    {
        public Form_Specialty()
        {
            InitializeComponent();
        }

        private void Form_Specialty_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter.Fill(this.schooltestDataSet.Specialty);

        }
        //===Обработка нажатия кнопки "Сохранить" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialtyBindingSource.EndEdit();
            this.specialtyTableAdapter.Update(this.schooltestDataSet.Specialty);
            MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
