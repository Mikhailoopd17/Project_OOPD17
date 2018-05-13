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
    public partial class Rating : Form
    {
        ArrayList listload = new ArrayList();
        ControlViewTable viewTable = new ControlViewTable();
        public Rating()
        {
            ControlViewTable table = new ControlViewTable();
            
            ControlDatabase control = new ControlDatabase();

            InitializeComponent();
            listload.AddRange(control.GetDataList("Childrens"));
            ViewTab(listload);
            
        }
        private double GetMidMark(int j)
        {
            double midBall = Math.Pow(j,1/2)/ Math.Pow(j, 1 / 3);
            Random rnd = new Random();
            int[] mas = new int[11];
            for (int i = 0; i < 11; i++)
            {
                int a = 0;
                while (true)
                {
                    if (a >= 20 && a < 50)
                    {
                        break;
                    }
                    else
                    {
                        a = rnd.Next(-20000, 100000);
                        continue;
                    }

                }

                if(!mas.Contains(a))
                {
                    mas[i] = a;
                    midBall += (double)a / 110;
                }
                else
                    i--;
                }
            return midBall;
        }
            

        public void ViewTab(ArrayList listLoad)
        {
            Children child = new Children();
            string[][] Mas = new string[listLoad.Count][];

            for (int i = 0; i < listLoad.Count; i++)
            {
                child = (Children)listLoad[i];
                Mas[i] = child.View();
            }
            if(listLoad.Count != 0)
                DGVsort.RowCount = listLoad.Count;
            else
                DGVsort.RowCount = 1
                    ;
            DGVsort.ColumnCount = 3;

            for (int k = 0; k < listLoad.Count; ++k)
            {
                DGVsort.Rows[k].Cells[1].Value = Mas[k][0];
                DGVsort.Rows[k].Cells[2].Value = (float)(GetMidMark(k));
            }
            DGVsort.Sort(Column3, ListSortDirection.Descending); 

            for (int k = 0; k < listLoad.Count; ++k)
            {
                DGVsort.Rows[k].Cells[0].Value = k + 1;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ViewTab(viewTable.FilterTable(viewTable.FilterTable(listload, comboBox2.Text, 6), comboBox1.Text, 5));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewTab(viewTable.FilterTable(viewTable.FilterTable(listload, comboBox2.Text, 6), comboBox1.Text, 5));
        }
    }
}
