using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    class ControlDatabase
    {
        public bool AutorizationChek(string Text1, string Text2, bool ok)
        {
            
            ok = false;
            string A = null;
            string B = null;
            //поодключение к БД
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=Autentification;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "SELECT * FROM Users";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) // построчно считываем данные
            {
                object Fio = reader.GetValue(1);
                object login = reader.GetValue(2);
                object password = reader.GetValue(3);

                A = login.ToString();
                B = password.ToString();
                if (A == Text1)  //если логин введен верно выполняем проверку пароля
                {
                    if (B == Text2)
                        break;
                }
                else
                    continue;
            }
            if (Text1 != A)
            {
                MessageBox.Show("Указанный логин не зарегистрирован!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ok = false;
            }
            else
            {
                if (Text2 != B)
                {
                    MessageBox.Show("Неверный пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return ok = false;
                }
                else
                {
                    reader.Close();
                    connection.Close();
                    return ok = true;
                }
            }
        }

        public void RegistrationUser(string text1, string text2, string text3)
        {
           
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=Autentification;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "INSERT INTO Users (FIO, login, password) VALUES ('" + text1 + "','" + text2 + "','" + text3 + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, регистрация не удалась!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
                MessageBox.Show("Регистрация прошла успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void addChildren(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            string childFio = text1 + " " + text2 + " " + text3;
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "INSERT INTO Childrens (ChildFio, Male, Birth, Phone, Adress) VALUES ('" + childFio + "','" + text4 + "','" + text5 + "','" + text6 + "','" + text7 + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, не удалось добавить запись!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
