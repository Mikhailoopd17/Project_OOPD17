using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    public partial class viewTable : Form
    {
        public viewTable()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void viewTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schooleDbDataSet.Childrens". При необходимости она может быть перемещена или удалена.
            this.childrensTableAdapter.Fill(this.schooleDbDataSet.Childrens);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
