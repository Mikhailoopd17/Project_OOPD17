using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Итоговый_проект.Plugins;

namespace Итоговый_проект.Forms
{
    public partial class ReportForm : Form
    {
        TempExchange<Children> temp = new TempExchange<Children>();
        TempExchange<Parent> tempPar1 = new TempExchange<Parent>();
        TempExchange<Parent> tempPar2 = new TempExchange<Parent>();

        public ReportForm(Children children, Parent parent1, Parent parent2)
        {
            InitializeComponent();
            temp.Get(children);
            tempPar1.Get(parent1);
            tempPar2.Get(parent2);
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Children ch = temp.Set();
            Parent par1 = tempPar1.Set();
            Parent par2 = tempPar2.Set();

            string[] tempFio = ch.getFio().Split(' ');

            String[] message = { "Отчет по ученику",
                                 "___________________________________________________",
                                 "Фамилия: " + tempFio[0],
                                 "Имя: " + tempFio[1],
                                 "Отчество: " + tempFio[2],
                                 "№ телефона: " +ch.getPhone(),
                                 "Класс: "+ch.getNumberClass()+ch.getLiter(),
                                 "Дата рождения: "+ch.getBirth(),
                                 "Домашний адрес: "+ch.getAdress(),
                                 "Родители/опекуны",
                                 "________________",
                                 "1) "+par1.getProximity() + " - "+par1.getFio(),
                                 "№ телефона: " +par1.getPhone(),
                                 "Домашний адрес: "+par1.getAdress(),
                                 "Место работы, должность: "+par1.getCompany()+", "+par1.getPosition(),
                                 "2) "+par2.getProximity() + " - "+par2.getFio(),
                                 "№ телефона: " +par2.getPhone(),
                                 "Домашний адрес: "+par2.getAdress(),
                                 "Место работы, должность: "+par2.getCompany()+", "+par2.getPosition(),
                                 "Табель успеваемости",
                                 "___________________"};
            String[,] messageTable = { {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Предмет", "I четверть", "II четверть", "III четверть", "VI четверть", "Итог" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Математика", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Русский язык", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Ин. язык", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Физкультура", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "География", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Музыка", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "ИЗО", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "ОБЖ", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "История", "", "", "", "", "" )},
                                       {string.Format("{0}               {1}     {2}    {3}    {4}     {5}", "Литература", "", "", "", "", "" )}};

            String Table = "_______________________________________________________________________";
            String Column = "|                               |                        |                     |                      |                       |                |";
            float[] X = { 300, 50, 100, 100, 100 , 400, 400, 400 , 100, 300, 300, 100,100,100,100, 100, 100, 100, 100, 300, 300 };
            float[] Y = { 50, 50, 100, 150, 200, 100, 150, 200 ,250 , 300,300,330,360,390,420, 470,500,530,560, 610,610};

            Font mesFontTitle = new Font("Cambria", 28, System.Drawing.GraphicsUnit.Point);
            Font mesFontSTitle = new Font("Times New Roman", 20, GraphicsUnit.Point);
            Font mesFontText = new Font("Times New Roman", 14, GraphicsUnit.Point);

            for (int i = 0; i < message.Length; i++)
            {
                if(i == 0 || i == 1)
                    PrintRow(sender, e, message[i], mesFontTitle, X[i], Y[i]);
                else if(i == 9 || i == 10||i == 19 || i == 20)
                    PrintRow(sender, e, message[i], mesFontSTitle, X[i], Y[i]);
                else
                    PrintRow(sender, e, message[i], mesFontText, X[i], Y[i]);
            }
            
            int f = 0;
            int a = 630;
            int b = 647;
            int c = 660;
            
            while (f <10)
            {
                PrintRow(sender, e, Table, mesFontText, 70, a);
                PrintRow(sender, e, Column, mesFontText, 70, b);
                PrintRow(sender, e, Column, mesFontText, 70, c);
                if(f == 9)
                    PrintRow(sender, e, Table, mesFontText, 70, c);
                a += 30;
                b += 30;
                c += 30;
                f++;
            }  // печать тела таблица

            for (int ii = 0, d = 655; ii < 10; ii++, d+=30)
            {
                for (int j = 0; j < 1; j++)
                {
                    if(ii == 0)
                        PrintRow(sender, e, messageTable[ii,j], mesFontText, 100, d);
                    else
                        PrintRow(sender, e, messageTable[ii, j], mesFontText, 90, d);
                }

            }  // заполнение таблицы

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            printPreviewDialog1.Close();
        }
        private void PrintRow(object sender, System.Drawing.Printing.PrintPageEventArgs e, string mes, Font mesFont, float x, float y)
        {
            Graphics g = e.Graphics;
            g.DrawString(mes, mesFont, Brushes.Black, x, y);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
