using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Итоговый_проект.Forms;
using Итоговый_проект.Plugins;

namespace Итоговый_проект
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }               
        private void button3_Click(object sender, EventArgs e)
        {
            AddChildren form4 = new AddChildren();
            form4.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewUpdate viewCh = new ViewUpdate
            {
                Text = "Список учеников"
            };
            viewCh.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewUpdate viewPar = new ViewUpdate
            {
                Text = "Список родителей"
            };
            viewPar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillDataBase fill = new FillDataBase();
            fill.Fill(Convert.ToInt16(txB.Text));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
