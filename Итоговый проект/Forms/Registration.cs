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
using System.Windows.Forms.VisualStyles;


namespace Итоговый_проект
{
    public partial class Registration : Form
    {
        KeyPressCheck chek1 = new KeyPressCheck();

        public Registration()
        {
            InitializeComponent();
            //контроль ввода символов в текстбоксы
            //tbRegLogin.KeyPress += new KeyPressEventHandler(chek1.CheckText);
            tbRegPass1.KeyPress += new KeyPressEventHandler(chek1.CheckText);
            tbRegPass2.KeyPress += new KeyPressEventHandler(chek1.CheckText);
            tbRegSname.KeyPress += new KeyPressEventHandler(chek1.CheckText2);
            tbRegName.KeyPress += new KeyPressEventHandler(chek1.CheckText2);
            tbRegFname.KeyPress += new KeyPressEventHandler(chek1.CheckText2);
        }
        private void tbRegPass2_TextChanged(object sender, EventArgs e)
        {
            if (tbRegPass1.Text == tbRegPass2.Text)
            {
                tbRegPass1.BackColor = Color.Green;
                tbRegPass2.BackColor = Color.Green;
                lblPas.Text = "Пароли совпадают";
                lblPas.ForeColor = Color.Green;
            }
            else
            {
                tbRegPass1.BackColor = Color.Red;
                tbRegPass2.BackColor = Color.Red;
                lblPas.Text = "Пароли не совпадают";
                lblPas.ForeColor = Color.Red;
            }
        }
        private void tbRegPass1_TextChanged(object sender, EventArgs e)
        {
            if (tbRegPass1.Text == tbRegPass2.Text)
            {
                tbRegPass1.BackColor = Color.Green;
                tbRegPass2.BackColor = Color.Green;
                lblPas.Text = "Пароли совпадают";
                lblPas.ForeColor = Color.Green;
            }
            else
            {
                tbRegPass1.BackColor = Color.Red;
                tbRegPass2.BackColor = Color.Red;
                lblPas.Text = "Пароли не совпадают";
                lblPas.ForeColor = Color.Red;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            string fio;
            KeyPressCheck logKey = new KeyPressCheck();

            if (tbRegName.Text == "" || tbRegSname.Text == "" || tbRegFname.Text == "") //проверяем на заполнение строк и сцепляем строки для получения ФИО
            {
                MessageBox.Show("Заполните все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                fio = tbRegSname.Text + " " + tbRegName.Text + " " + tbRegFname.Text;
                if (tbRegPass1.Text != tbRegPass2.Text) //проверяем на правильность повтора пароля
                {
                    MessageBox.Show("Введенные пароли не совпадают", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (tbRegPass1.Text == "") //проверяем на правильность ввода пароля
                        MessageBox.Show("Заполните поле пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (logKey.CheckText(tbRegLogin.Text)) //проверяем на заполение поле логин
                        {
                            //поодключение к БД
                            ControlDatabase addUser = new ControlDatabase();
                            addUser.RegistrationUser(fio, tbRegLogin.Text, tbRegPass2.Text);
                            Close();
                        }
                        else
                            MessageBox.Show("Проверьте поле логин", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbRegLogin_TextChanged(object sender, EventArgs e)
        {
            string A = null;
            //поодключение к БД
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=Autentification;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "SELECT * FROM Users";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // построчно считываем данные
            {
                object login = reader.GetValue(2);
                A = login.ToString();
                if (A == tbRegLogin.Text)  //если логин введен верно выполняем проверку пароля
                {
                    lblLogOk.Text = "Логин занят!";
                    lblLogOk.ForeColor = Color.Red;
                    break;
                }
                else
                {
                    lblLogOk.Text = "Логин подходит для регистрации!";
                    lblLogOk.ForeColor = Color.Green;
                    continue;
                }
            }
            reader.Close();
            connection.Close();  
        }
    }
}


