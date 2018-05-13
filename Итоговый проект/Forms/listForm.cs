using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект.Forms
{
    public partial class listForm : Form
    {
        public listForm()
        {
            InitializeComponent();
            RatingForm_Load();
        }
        public void RatingForm_Load()
        {
            string[] Pred ={"Математика",
                        "Русский язык",
                        "Литература",
                        "Иностранный язык",
                        "Физкультура",
                        "История",
                        "География",
                        "Музыка",
                        "ИЗО ",
                        "ОБЖ"};
            printRatingTable(Pred, DGVdata);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void printRatingTable(string[]mas, DataGridView DGV)
        {
            DGV.RowCount = mas.Length;
            DGV.ColumnCount = 6;

            for (int k = 0; k < mas.Length; ++k)
            {
                DGV.Rows[k].Cells[0].Value = mas[k];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int k = 0; k < DGVdata.RowCount; ++k)
            {
                for (int i = 1; i < DGVdata.ColumnCount; i++)
                {
                    DGVdata.Rows[k].Cells[i].Value = RandomInput(random.Next(-5,5));
                }
                
            }
            for (int j = 0; j < DGVdata.RowCount; j++)
            {
                DGVdata.Rows[j].Cells[5].Value = getMark(j);
            }
        }

        private int RandomInput(int i)
        {
            Random rand = new Random();
            int coun = Math.Abs(rand.Next(-200, 200) / (i + 10));
            if (coun > 2 && coun < 6)
                return coun;
            else
                return RandomInput(Math.Abs(rand.Next(-10 * coun, 10 * coun + 1)));
        }

        private double getMark(int k)
        {
            double mark = 0;
            for (int i = 1; i < 5; i++)
            {
                int temp = Convert.ToUInt16(DGVdata.Rows[k].Cells[i].Value);
                mark += temp; 
            }
            return Math.Round(mark / 4, MidpointRounding.AwayFromZero);
        }

        public double GetMidmark()
        {
            double sum = 0;
            for (int i = 0; i < 11; i++)
            {
                sum += RandomInput(1);
            }
            return sum / 11;
        }
    }
}
