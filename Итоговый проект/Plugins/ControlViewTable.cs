using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Итоговый_проект.Forms;

namespace Итоговый_проект.Plugins
{
    class ControlViewTable
    {
        public void ViewTable(DataGridView DGV, ArrayList listLoad, string nameTable)
        {
            if (nameTable == "Childrens")
            {
                Children child = new Children();
                string[][] Mas = new string[listLoad.Count][];

                for (int i = 0; i < listLoad.Count; i++)
                {
                    child = (Children)listLoad[i];
                    Mas[i] = child.View();
                }

                DGV.RowCount = listLoad.Count;
                DGV.ColumnCount = 7;

                for (int k = 0; k < listLoad.Count; ++k)
                {
                    DGV.Rows[k].Cells[0].Value = k + 1;
                    for (int j = 1; j < 7; ++j)
                    {
                        if (j < 2)
                            DGV.Rows[k].Cells[j].Value = Mas[k][j - 1];
                        else if (j >= 2)
                            DGV.Rows[k].Cells[j].Value = Mas[k][j];
                    }

                }
            }
            else if (nameTable == "Parents")
            {
                Parent parent = new Parent();
                string[][] Mas = new string[listLoad.Count][];

                for (int i = 0; i < listLoad.Count; i++)
                {
                    parent = (Parent)listLoad[i];
                    Mas[i] = parent.View();
                }

                DGV.RowCount = listLoad.Count;
                DGV.ColumnCount = 8;
                DGV.Columns[1].HeaderText = "ФИО родителя";
                DGV.Columns[1].Width = 200;
                DGV.Columns[2].HeaderText = "Родство";
                DGV.Columns[2].Width = 50;
                DGV.Columns[3].HeaderText = "Дата рождения";
                DGV.Columns[3].Width = 60;
                DGV.Columns[4].HeaderText = "Номер телефона";
                DGV.Columns[4].Width = 100;
                DGV.Columns[5].HeaderText = "Адрес";
                DGV.Columns[5].Width = 150;
                DGV.Columns[6].HeaderText = "Должность";
                DGV.Columns[6].Width = 75;
                DGV.Columns[7].HeaderText = "Компания";
                DGV.Columns[7].Width = 75;

                for (int k = 0; k < listLoad.Count; ++k)
                {
                    DGV.Rows[k].Cells[0].Value = k + 1;
                    for (int j = 1; j < 8; ++j)
                        DGV.Rows[k].Cells[j].Value = Mas[k][j - 1];
                }
            }
        }

        public ArrayList FilterTable(ArrayList list, string text, int position) //position: 0-фио, 1 - пол, 2-дата рождения, 3-телефон,4-адрес, 5-№класса, 6-литер
        {
            ArrayList temp = new ArrayList();
            
            foreach (Person ch in list)
            {
                string[] mas = ch.View();
                if (mas[position].ToLower().Contains(text.ToLower()))
                    temp.Add(ch);
            }
            return temp;
        }

    }
}
