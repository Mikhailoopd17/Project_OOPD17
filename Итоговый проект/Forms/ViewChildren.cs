using System;
using System.Collections;
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
    public partial class ViewUpdate : Form
    {
        TempExchange<ArrayList> tempExchange = new TempExchange<ArrayList>();

        ArrayList listLoad = new ArrayList();
        ControlViewTable table = new ControlViewTable();
        string nameTable = "";

        public ViewUpdate()
        {
            InitializeComponent();
            DGVtable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ViewUpdate_Load(object sender, EventArgs e)
        {
            ControlDatabase control = new ControlDatabase();

            if(Text == "Список учеников")
            {
                listLoad.AddRange(control.GetDataList("Childrens"));
                nameTable = "Childrens";
            }
            else if (Text == "Список родителей")
            {
                string[] mas =
                {
                    "",
                    "Мама",
                    "Папа",
                    "Брат",
                    "Сестра",
                    "Бабушка",
                    "Дедушка",
                    "Дядя",
                    "Тетя",
                    "Опекун"
                };

                listLoad.AddRange(control.GetDataList("Parents"));
                nameTable = "Parents";
                btnDel.Enabled = false;
                lblLiter.Text = "Компания";
                lblNumber.Text = "Должность";
                lblMale.Text = "Родство";
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(mas);

                btnDel.Enabled = false;
                btnDelAll.Enabled = false;
                btnReport.Enabled = false;
                button1.Enabled = false;
                Text = "Список родителей";
            }
            table.ViewTable(DGVtable, listLoad, nameTable);
        }
        //int position: 0-фио, 1 - пол, 2-дата рождения, 3-телефон,4-адрес, 5-№класса, 6-литер
        public void txbFioSearch_TextChanged(object sender, EventArgs e)
        {
            table.ViewTable(DGVtable, table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(listLoad, comboBox1.Text, 1), txbBirthSearch.Text, 2), txbLiterSearch.Text, 6), txbNumberSearch.Text, 5), txbFioSearch.Text, 0), nameTable);
        }

        private void txbNumberSearch_TextChanged(object sender, EventArgs e)
        {
            table.ViewTable(DGVtable, table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(listLoad, comboBox1.Text, 1), txbBirthSearch.Text, 2), txbLiterSearch.Text, 6), txbFioSearch.Text, 0), txbNumberSearch.Text, 5), nameTable);
        }

        private void txbLiterSearch_TextChanged(object sender, EventArgs e)
        {
            table.ViewTable(DGVtable, table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(listLoad, comboBox1.Text, 1), txbBirthSearch.Text, 2), txbNumberSearch.Text, 5), txbFioSearch.Text, 0), txbLiterSearch.Text, 6), nameTable);
        }

        private void txbBirthSearch_TextChanged(object sender, EventArgs e)
        {
            table.ViewTable(DGVtable, table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(listLoad, comboBox1.Text, 1), txbLiterSearch.Text, 6), txbNumberSearch.Text, 5), txbFioSearch.Text, 0), txbBirthSearch.Text, 2), nameTable);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            table.ViewTable(DGVtable, table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(table.FilterTable(listLoad, comboBox1.Text, 1), txbLiterSearch.Text, 6), txbNumberSearch.Text, 5), txbFioSearch.Text, 0), txbBirthSearch.Text, 2), nameTable);
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            ControlDatabase controlDB = new ControlDatabase();
            
            if (Text == "Список учеников")
            {
                /*получаем из БД массив параметров ученика по выбранной строке->
             * по его id находим родителей и получаем массивы их параметров поочередно->
             * создаем объекты ученик и родитетей->
             * загружаем на форму ученика и родитетей*/
                string[] param = controlDB.GetPerson(DGVtable.CurrentRow.Cells[1].Value.ToString(), "Childrens");
                Children childrenUpdate = new Children(param[1], param[2], param[3], param[4], param[5], Convert.ToByte(param[6]), param[7]);
                int[] idPar = controlDB.GetID(Convert.ToInt32(param[0]));
                string[] paramP1 = controlDB.GetPerson(idPar[0], "Parents");
                Parent parentUpdate1 = new Parent(paramP1[1], paramP1[2], paramP1[3], paramP1[4], paramP1[5], paramP1[6], paramP1[7]);
                string[] paramP2 = controlDB.GetPerson(idPar[1], "Parents");
                Parent parentUpdate2 = new Parent(paramP2[1], paramP2[2], paramP2[3], paramP2[4], paramP2[5], paramP2[6], paramP2[7]);
                //настраиваем форму ученика
                AddChildren updCh = new AddChildren(childrenUpdate, parentUpdate1, parentUpdate2);
                updCh.btAdd.Text = "Изменить";
                updCh.ShowDialog();
                //обновляем таблицу
                listLoad.Clear();
                ViewUpdate_Load(sender, e);
                txbFioSearch_TextChanged(sender, e);

            }
            else if (Text == "Список родителей")
            {
                /*получаем из БД массив параметров родителя по выбранной строке->
             * загружаем на форму родителя*/
                string[] param = controlDB.GetPerson(DGVtable.CurrentRow.Cells[1].Value.ToString(), "Parents");
                Parent parentUpdate = new Parent(param[1], param[2], param[3], param[4], param[5], param[6], param[7]);
                //настраиваем форму ученика
                AddParents updPar = new AddParents(parentUpdate);
                updPar.btnOK.Text = "Изменить";
                updPar.ShowDialog();
                //обновляем таблицу
                listLoad.Clear();
                ViewUpdate_Load(sender, e);
                txbFioSearch_TextChanged(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить ученика?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            { }
            else
            {
                ControlDatabase control = new ControlDatabase();
                if (Text == "Список учеников")
                {
                    int id = control.GetID("Childrens", DGVtable.CurrentRow.Cells[1].Value.ToString());
                    int[] idPar = control.GetID(id);

                    control.Delete(id, "NoteKeys", "ChID");
                    control.Delete(id, "Childrens", "ID");
                    foreach (int i in idPar)
                        control.Delete(i, "Parents", "ID");
                    //обновляем таблицу
                    listLoad.Clear();
                    ViewUpdate_Load(sender, e);

                }
            }
        }


        private void btnDelAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить всех учеников?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            { }
            else
            {
                ControlDatabase control = new ControlDatabase();
                control.Delete("NoteKeys");
                control.Delete("Childrens");
                control.Delete("Parents");
                //обновляем таблицу
                listLoad.Clear();
                ViewUpdate_Load(sender, e);
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ControlDatabase control = new ControlDatabase();
            string[] param = control.GetPerson(DGVtable.CurrentRow.Cells[1].Value.ToString(), "Childrens");
            Children childrenReport = new Children(param[1], param[2], param[3], param[4], param[5], Convert.ToByte(param[6]), param[7]);
            int[] idPar = control.GetID(Convert.ToInt32(param[0]));
            string[] paramP1 = control.GetPerson(idPar[0], "Parents");
            Parent parentReport1 = new Parent(paramP1[1], paramP1[2], paramP1[3], paramP1[4], paramP1[5], paramP1[6], paramP1[7]);
            string[] paramP2 = control.GetPerson(idPar[1], "Parents");
            Parent parentReport2 = new Parent(paramP2[1], paramP2[2], paramP2[3], paramP2[4], paramP2[5], paramP2[6], paramP2[7]);

            ReportForm report = new ReportForm(childrenReport, parentReport1, parentReport2);
            report.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = listLoad;
            ListPrint print = new ListPrint(list);
            print.ShowDialog();
        }
    }
}
