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
        public ListPrint(ArrayList arrayList)
        {
            InitializeComponent();
            temp.Get(arrayList);
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
            ArrayList list = temp.Set();
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

            String[] message = { "Список класса "+Mas[0][5]+ Mas[0][6], "___________________________________________________" };

            String Table = "___________________________________________________";
            String Column = "|    |                                                       |                                        |";
            String[] messageTable = { string.Format(" {0}                     {1}                               {2}", "№", "ФИО", "Примечание") };


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
    }
}
