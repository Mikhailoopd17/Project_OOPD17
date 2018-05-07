using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    public partial class AddParents : Form
    {
        public AddParents()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        ContextMenuStrip contextMenuStrip2;
        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // тут проверяешь e.ClickedItem, и в зависимости от него выполняешь нужные действия
        }
        void Button1Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Items.Clear(); // Ну, или сразу в OnLoad заполняешь пункты
            contextMenuStrip2.Items.Add("Очистить \"Начислено\"");
            contextMenuStrip2.Items.Add("Очистить \"Уплачено\"");
            contextMenuStrip2.Items.Add("-");
            contextMenuStrip2.Items.Add("Очистить все");

            contextMenuStrip2.Show(button1, new Point(0, button1.Height));
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip2_ItemClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
