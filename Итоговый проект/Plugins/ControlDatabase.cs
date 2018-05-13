using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Итоговый_проект.Plugins;

namespace Итоговый_проект
{
    class ControlDatabase
    {
        public bool AutorizationChek(string Text1, string Text2, bool ok)
        {
            //TempExchange <String> temp = new TempExchange<String>();

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

                //temp.Get(Fio.ToString());

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

        public void Add(string fio, string male, string birth, string phone, string adress, byte numClass, string liter)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "INSERT INTO Childrens (FIO, MALE, BIRTH, PHONE, ADRESS, NUMCLASS, LITER) VALUES ('" + fio + "','" + male + "','" + birth + "','" + phone + "','" + adress + "','" + numClass + "','" + liter + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException e)
            {
                e.ToString();
                MessageBox.Show("Ошибка, Childrens!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Add(string fio, string proximity, string birth, string phone, string adress, string position, string company)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "INSERT INTO Parents (FIO, PROXIMITY, BIRTH, PHONE, ADRESS, POSITION, COMPANY) VALUES ('" + fio + "','" + proximity + "','" + birth + "','" + phone + "','" + adress + "','" + position + "','" + company + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
               // MessageBox.Show("Запись успешно добавлена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, Parents!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Add(int chId, int parId)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "INSERT INTO NoteKeys (ChID, ParID) VALUES ('" + chId + "','" + parId + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка, Keys!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }

        public int GetLastID(string nameTable)
        {
            int ID = 0;
            string sqlExpression = "SELECT ID FROM " + nameTable + "";
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader readerID = command.ExecuteReader();
            try
            {
                while (readerID.Read())
                {
                    ID = (Int32)readerID.GetValue(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка, не удалось получить ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }
        public int GetID(string nameTable, string fio)
        {
            int ID = 0;
            string sqlExpression = "SELECT * FROM " + nameTable + "";
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader readerID = command.ExecuteReader();
            try
            {
                while (readerID.Read())
                {
                    if (readerID.GetValue(1).Equals(fio))
                        break;
                    else
                        continue;
                }
                ID = (Int32)readerID.GetValue(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка, не удалось получить ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return ID;
        }// оптимизировать по диапазону параметров
        public int[] GetID(int ID)
        {
            int[] tempID = new int[2];
            string sqlExpression = "SELECT * FROM NoteKeys";
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                int count = 0;
                while (reader.Read())
                {
                    while (count < 2)
                    {
                        if (reader.GetValue(1).Equals(ID))
                        {
                            tempID[count] = Convert.ToInt16(reader.GetValue(2));
                            count++;
                            break;
                        }
                        else
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка, не удалось получить ID!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return tempID;
        } // оптимизировать по диапазону параметров

        public IList GetDataList(string nameTable)
        {
            ArrayList list = new ArrayList();

            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "SELECT * FROM "+nameTable+"";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                // вариант с коллекцией
                //ArrayList temp = new ArrayList();
                //for (int i = 1; i <= 7; i++)
                //    temp.Add(reader.GetValue(i));
                //list.AddRange(temp);
               
                // вариант с массивом
                string[] temp = new string[7];
                for (int i = 1; i <= 7; i++)
                {
                    temp[i - 1] = reader.GetValue(i).ToString();
                }
                if(nameTable.Equals("Childrens"))
                {
                    Children person = new Children(temp[0], temp[1], temp[2], temp[3], temp[4], Convert.ToByte(temp[5]), temp[6]);
                    list.Add(person);
                }
                else if(nameTable.Equals("Parents"))
                {
                    Parent person = new Parent(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    list.Add(person);
                }         
            }
            return list;
        }
        public IList GetDataList(string nameTable, string parameter)
        {
            ArrayList list = new ArrayList();

            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "SELECT * FROM Childrens";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetValue(1).ToString());
            }
            return list;
        }
        public string[] GetPerson(string inpFio, string nameTable)
        {
             string[] tempPerson = new string[8];
            string sqlExpression = "SELECT * FROM "+ nameTable +"";
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.GetValue(1).Equals(inpFio)) 
                        break;
                    else
                        continue;
                }
                for (int i = 0; i < 8; i++)
                {
                    tempPerson[i] = reader.GetValue(i).ToString().Trim();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка, не удалось получить Children!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return tempPerson;
        }//получить по ФИО
        public string[] GetPerson(int id, string nameTable)
        {
            string[] tempPerson = new string[8];
            string sqlExpression = "SELECT * FROM "+ nameTable +""; ;
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlExpression, connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.GetValue(0).Equals(id))
                        break;
                    else
                        continue;
                }
                for (int i = 0; i < 8; i++)
                {
                    tempPerson[i] = reader.GetValue(i).ToString().Trim();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка, не удалось получить Person!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
            return tempPerson;
        }//получить по id

        public void Update(string fio, string male, string birth, string phone, string adress, byte numClass, string liter, int id)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "UPDATE Childrens SET FIO = '" + fio + "', MALE = '" + male + "', BIRTH = '" + birth + "', PHONE ='" + phone + "', ADRESS = '" + adress + "', NUMCLASS = '" + numClass + "', LITER = '" + liter + "' WHERE ID = '" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException e)
            {
                e.ToString();
                MessageBox.Show("Ошибка, Childrens!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Update(string fio, string proximity, string birth, string phone, string adress, string position, string company, int id)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "UPDATE Parents SET FIO = '" + fio + "', PROXIMITY = '" + proximity + "', BIRTH = '" + birth + "', PHONE ='" + phone + "', ADRESS = '" + adress + "', POSITION = '" + position + "', COMPANY = '" + company + "' WHERE ID = '" + id + "'";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException e)
            {
                e.ToString();
                MessageBox.Show("Ошибка, Parents!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }

        public void Delete(int id, string nameTable, string col)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "DELETE "+nameTable+ " WHERE " + col + " = " + id + "";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException e)
            {
                e.ToString();
                MessageBox.Show("Ошибка, Parents!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
        public void Delete(string nameTable)
        {
            string connectionString = @"Data Source=HOME-PC;Initial Catalog=SchooleDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlExpression = "DELETE " + nameTable + "";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException e)
            {
                e.ToString();
                MessageBox.Show("Ошибка, Parents!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
