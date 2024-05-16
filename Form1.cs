using PL23.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL23
{
    public partial class Form1 : Form
    {
        public static int IdC;
        public Form1()
        {
            InitializeComponent();
        }

        private void competitionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competitionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "northwindDataSet.Competitions". При необходимости она может быть перемещена или удалена.
            this.competitionsTableAdapter.Fill(this.northwindDataSet.Competitions);
        }

        private void competitionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (competitionsDataGridView.SelectedRows.Count > 0) // Проверка на выделенную строку
            {
                //  Получение значения  IdC  из выбранной строки
                Form1.IdC = Convert.ToInt32(competitionsDataGridView.SelectedRows[0].Cells[0].Value);

                //  Переход на форму 2
                Form3 form2 = new Form3(); 
                form2.Show();
            }
            else
            {
                MessageBox.Show("Выберите строку в таблице.", "Ошибка");
            }
        }
    }
}
