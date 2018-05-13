using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Итоговый_проект.Plugins;

namespace Итоговый_проект
{
    public partial class AddParents : Form
    {
        private string fio
        {
            get
            {
                string temp = txbSurname.Text + " " + txbName.Text + " " + txbFname.Text;
                return temp;
            }
            set
            {

            }
        }
        private string birth
        {
            get
            {
                return txDateOfB.Text;
            }
            set
            {

            }
        }
        private string phone
        {
            get
            {
                return txbPhone.Text;
            }
            set
            {

            }
        }
        private string adress
        {
            get
            {
                return txbAdress.Text;
            }
            set
            {

            }
        }
        private string proximity
        {
            get
            {
                    return cbProx.Text;
            }
            set
            {

            }
        }
        private string position
        {
            get
            {
                return txbPosition.Text;
            }
            set
            {

            }
        }
        private string company
        {
            get
            {
                return txbCompany.Text;
            }
            set
            {

            }
        }

        TempExchange<Parent> temp = new TempExchange<Parent>();

        public Parent getTemp()
        {
            return temp.Set();
        }
  
        public AddParents()
        {
            InitializeComponent();
        }
        public AddParents(Parent parent)
        {
            InitializeComponent();

            string[] tempFio = parent.getFio().Split(' ');
            txbSurname.Text = tempFio[0];
            txbName.Text = tempFio[1];
            txbFname.Text = tempFio[2];

            txDateOfB.Text = parent.getBirth();
            txbCompany.Text = parent.getCompany();
            txbAdress.Text = parent.getAdress();
            txbPosition.Text = parent.getPosition();
            txbPhone.Text = parent.getPhone();
            cbProx.Text = parent.getProximity();
            temp.Get(parent);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void btnOK_Click(object sender, EventArgs e)
        {
            
            if (btnOK.Text == "ОК")
            {
                Parent parent = new Parent(fio, proximity, birth, phone, adress, position, company); // создаем родителя
                temp.Get(parent); // передаем его во временное хранилище и возвращаем на форму addChildren
                Close();
            }
            if (btnOK.Text == "Изменить")
            {
                Parent parent = temp.Set();
                Parent _parent = new Parent(fio, proximity, birth, phone, adress, position, company); // создаем родителя
                ControlDatabase database = new ControlDatabase();
                _parent.Update(database.GetID("Parents", parent.getFio())); // обновляем родителя в БД 
                Close();
            }
        }
    }
}

