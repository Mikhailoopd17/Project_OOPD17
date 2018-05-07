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
    
    public partial class addChildren : Form
    {
        string male;
        
        public addChildren()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            KeyPressCheck cheker = new KeyPressCheck();
            if (cheker.CheckText3(male))
            {
                ControlDatabase addChildren = new ControlDatabase();
                addChildren.addChildren(txNameChild.Text, txSnameChild.Text, txFnameChild.Text, male, txDateOfB.Text, txPhone.Text, txAdress.Text);
            }
            else
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void rbM_CheckedChanged(object sender, EventArgs e)
        {
            male = "муж";
        }

        public void rbJ_CheckedChanged(object sender, EventArgs e)
        {
            male = "жен";
        }

        private void btAddParents_Click(object sender, EventArgs e)
        {
            AddParents form6 = new AddParents();
            form6.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
