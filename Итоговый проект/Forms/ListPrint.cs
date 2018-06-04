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
using Итоговый_проект.Plugins;

namespace Итоговый_проект.Forms
{
    public partial class ListPrint : Form
    {
        TempExchange<ArrayList> temp = new TempExchange<ArrayList>();
        ControlViewTable tab = new ControlViewTable();

        public ListPrint(ArrayList arrayList)
        {
            InitializeComponent();
            temp.Get(arrayList);

            ViewTable(DGV, arrayList);
        }

        private void PrintRow(object sender, System.Drawing.Printing.PrintPageEventArgs e, string mes, Font mesFont, float x, float y)
        {
            Graphics g = e.Graphics;
            g.DrawString(mes, mesFont, Brushes.Black, x, y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ArrayList list = tab.FilterTable(tab.FilterTable(temp.Set(), comboBox2.Text, 6), comboBox1.Text, 5);
            Children ch = new Children();
            
            string[][] Mas = new string[list.Count][];
            for (int i = 0; i < list.Count; i++)
            {
                ch = (Children)list[i];
                Mas[i] = ch.View();
            }

            Font mesFontTitle = new Font("Cambria", 28, GraphicsUnit.Point);
            Font mesFontSTitle = new Font("Times New Roman", 20, GraphicsUnit.Point);
            Font mesFontText = new Font("Times New Roman", 14, GraphicsUnit.Point);

            String[] message = { "Список класса "+comboBox1.Text+ comboBox2.Text, "___________________________________________________" };

            String Table = "___________________________________________________";
            String Column = "|    |                                                              |                                 |";
            String[] messageTable = { string.Format(" {0}                        {1}                               {2}", "№", "ФИО", "Примечание") };


            PrintRow(sender, e, message[0], mesFontTitle, 300, 50);
            PrintRow(sender, e, message[1], mesFontTitle, 70, 50);
            PrintRow(sender, e, messageTable[0], mesFontText, 150, 122);

            for (int i = 0, k = 150, l = 100; i < list.Count+1; i++, l += 30)
            {
                PrintRow(sender, e, Table, mesFontText, k, l);
                PrintRow(sender, e, Column, mesFontText, k, l + 15);
                PrintRow(sender, e, Column, mesFontText, k, l + 30);
                PrintRow(sender, e, Table, mesFontText, k, l + 30);
            }
            for (int i = 1, k = 150, l = 100; i < list.Count+1; i++, l+=30)
            {
                String[] messageTable1 = { string.Format(" {0}  {1}                               {2}", i, Mas[i-1][0], "") };
                PrintRow(sender, e, messageTable1[0], mesFontText, k, l + 55);
            }

        }

        private void printPreviewDialog1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewTable(DGV, tab.FilterTable(tab.FilterTable(temp.Set(), comboBox2.Text, 6), comboBox1.Text, 5));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewTable(DGV, tab.FilterTable(tab.FilterTable(temp.Set(), comboBox2.Text, 6), comboBox1.Text, 5));
        }
        public void ViewTable(DataGridView DGV, ArrayList listLoad)
        {
            Children child = new Children();
            string[][] Mas = new string[listLoad.Count][];

            for (int i = 0; i < listLoad.Count; i++)
            {
                child = (Children)listLoad[i];
                Mas[i] = child.View();
            }

            if (listLoad.Count > 0)
            {
                DGV.RowCount = listLoad.Count;
                DGV.ColumnCount = 3;

                for (int k = 0; k < listLoad.Count; ++k)
                {
                    DGV.Rows[k].Cells[0].Value = k + 1;
                    for (int j = 0; j < 7; ++j)
                    {
                        if (j == 0)
                            DGV.Rows[k].Cells[j + 1].Value = Mas[k][j];

                    }

                }
            }
            else
            {
                DGV.RowCount = 1;
                DGV.Rows[0].Cells[0].Value = "";
                DGV.Rows[0].Cells[1].Value = "Ничего не найдено";
            }

            
        }
    }
}
