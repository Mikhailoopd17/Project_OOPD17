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
            addChildren form4 = new addChildren();
            form4.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewUpdate form3 = new ViewUpdate();
            form3.ShowDialog();
        }
        private void btRedact_Click(object sender, EventArgs e)
        {
            //Delete form5 = new Delete();
            //form5.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }


    }
}
