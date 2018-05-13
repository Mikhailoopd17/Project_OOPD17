using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    class KeyPressCheck
    {
        public void CheckText(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar >= 65) && (e.KeyChar <= 90) || (e.KeyChar >= 97) && (e.KeyChar <= 122) || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
            {
                e.Handled = true;
            }
        }
        public void CheckText2(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)1040) && (e.KeyChar <= (char)1103) || (e.KeyChar == '-') || (e.KeyChar == '_') || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;
            else
            {
                e.Handled = true;
            }
        }
        public bool CheckText3(string A)
        {
            if (A == "" || A == " ")
            {
                return false;
            }
            else
                return true;
        }
        public bool CheckText(String Text)
        {
            Regex regex = new Regex(@"[A-Za-z0-9]{5,}");
            MatchCollection matches = regex.Matches(Text);
            if (matches.Count == 1)
                return true;
            else
                return false;
        }
        public bool ChekInputText(KeyPressEventArgs e)
        {
            if (e.Handled)
                return true;
            else
                return false;
        }
    }
}

