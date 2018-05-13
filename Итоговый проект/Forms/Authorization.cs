using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void button2_Click(object sender, EventArgs e)
        {
            bool identy = false;
            ControlDatabase autorization = new ControlDatabase();
            
            if (autorization.AutorizationChek(tbName.Text, tbSname.Text, identy))
            {
                mainMenu form2 = new mainMenu();  //создаем ссылку на 2 форму
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            Registration formReg = new Registration();  //создаем форму регистрации
            this.Hide();
            formReg.Show();
            this.Show();
        }
    }
}
