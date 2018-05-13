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
using Итоговый_проект.Forms;
using Итоговый_проект.Plugins;

namespace Итоговый_проект
{
    
    public partial class AddChildren : Form
    {
        TempExchange<Parent> temp = new TempExchange<Parent>();
        ControlDatabase control = new ControlDatabase();
        
        string c = "Childrens";
        string p = "Parents";

        Children childUpdate = null;
        Parent _parent1 = null;
        Parent _parent2 = null;

        protected int IDpar1 = 0;
        protected int IDpar2 = 0;
        protected int IDch = 0;

        private string fio
        {
            get
            {
                string temp = txSnameChild.Text + " " + txNameChild.Text + " " + txFnameChild.Text;
                return temp; 
            }
            set
            {
                fio = value;
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
                birth = value;
            }
        }
        private string phone
        {
            get
            {
                return txPhone.Text;
            }
            set
            {
                phone = value;
            }
        }
        private string adress
        {
            get
            {
                return txAdress.Text;
            }
            set
            {
                adress = value;
            }
        }
        private string male
        {
            get
            {
                if (rbM.Checked)
                    return "муж";
                else if (rbJ.Checked)
                    return "жен";
                else
                    return "";
            }
            set
            {

            }
        }
        private byte numberClass
        {
            get
            {
                return byte.Parse(txNumClass.Text);
            }
            set
            {

            }
        }
        private string liter
        {
            get
            {
                return txLiter.Text;
            }
            set
            {

            }
        }
        
        public AddChildren()
        {
            InitializeComponent();
        }
        public AddChildren(Children children, Parent par1, Parent par2)
        {
            childUpdate = children;
            _parent1 = par1;
            _parent2 = par2;
            InitializeComponent();

            string[] tempFio = childUpdate.getFio().Split(' ');
            txSnameChild.Text = tempFio[0];
            txNameChild.Text = tempFio[1];
            txFnameChild.Text = tempFio[2];

            txDateOfB.Text = childUpdate.getBirth();
            txAdress.Text = childUpdate.getAdress();
            txPhone.Text = childUpdate.getPhone();
            txNumClass.Text = childUpdate.getNumberClass().ToString();
            txLiter.Text = childUpdate.getLiter();

            if (childUpdate.getMale() == "муж")
                rbM.Checked = true;
            else if (childUpdate.getMale() == "жен")
                rbJ.Checked = true;

            tbFirstPar.Text = _parent1.getFio();
            btnPar1Add.Enabled = false;
            tbSecondPar.Text = _parent2.getFio();
            btnPar2Add.Enabled = false;
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btAdd_Click(object sender, EventArgs e)
        {
            if(btAdd.Text == "Добавить")
            {
                Children children1 = new Children(fio, male, birth, phone, adress, numberClass, liter);
                children1.Add(); // добавляем ученика в БД и читаем его id для создания связи ученик - родитель
                IDch = control.GetLastID(c);
                _parent1.Add(); // добавляем родителя в БД и читаем его id для создания связи ученик - родитель
                IDpar1 = control.GetLastID(p);
                _parent2.Add();
                IDpar2 = control.GetLastID(p);
                control.Add(IDch, IDpar1); // создаем связь 1 ученика с двумя родителями (2 строки в бд)
                control.Add(IDch, IDpar2);
                Close();
            }
            if(btAdd.Text == "Изменить")
            {
                Children ch = new Children(fio, male, birth, phone, adress, numberClass, liter);
                ControlDatabase database = new ControlDatabase();
                IDch = database.GetID("Childrens", childUpdate.getFio());
                ch.Update(IDch); // обновляем ученика в БД 
                Close();
            }
            
        }

        public void btAddParents_Click(object sender, EventArgs e)
        {
            AddParents addPar = new AddParents();
            addPar.ShowDialog();
            _parent1 = addPar.getTemp();  //получаем родителя из временного хранилища и выводим ФИО в тб
            if(_parent1 != null)
                tbFirstPar.Text = _parent1.getFio();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            AddParents addPar = new AddParents();
            addPar.ShowDialog();
            _parent2 = addPar.getTemp();
            if (_parent2 != null)
                tbSecondPar.Text = _parent2.getFio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listForm rating = new listForm();
            rating.lblFio.Text = fio;
            rating.ShowDialog();
        }
    }
}
