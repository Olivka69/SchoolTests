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
    public partial class Form_Modules : Form
    {
        public Form_Modules()
        {
            InitializeComponent();
        }

        private void Form_Modules_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Disciplines". При необходимости она может быть перемещена или удалена.
            this.disciplinesTableAdapter.Fill(this.schooltestDataSet.Disciplines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooltestDataSet.Modules". При необходимости она может быть перемещена или удалена.
            this.modulesTableAdapter.Fill(this.schooltestDataSet.Modules);

        }
        //===Обработка нажатия кнопки "Сохранить" (попытка записи изменений в БД)
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modulesBindingSource.EndEdit();
            this.modulesTableAdapter.Update(this.schooltestDataSet.Modules);
            MessageBox.Show("Данные записаны!", "Операция прошла успешно", MessageBoxButtons.OK);
        }
        //===Обработка нажатия кнопки "Закрыть"
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
