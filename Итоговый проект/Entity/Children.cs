using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Итоговый_проект
{
    public class Children : Person
    {
        string Male { get; set; }
        byte NumberClass { get; set; }
        string Liter { get; set; }


        public byte getNumberClass()
        {
            return NumberClass;
        }
        public string getLiter()
        {   
            return Liter;
        }
        public string getMale()
        {
            return Male;
        }

        public Children()
        {
            NumberClass = 0;
            Liter = "";
            Male = "";
        }
        public Children(string fio, string male, string birth, string phone, string adress, byte numberClass, string liter) 
            :base(fio, birth, adress, phone)
        {
            NumberClass = numberClass;
            Liter = liter;
            Male = male;
        }
        public override void Add()
        {
            ControlDatabase ch1 = new ControlDatabase();
            ch1.Add(getFio(), getMale(), getBirth(), getPhone(), getAdress(), getNumberClass(), getLiter());
        }
        public override void Update(int id)
        {
            ControlDatabase control = new ControlDatabase();
            control.Update(getFio(), getMale(), getBirth(), getPhone(), getAdress(), getNumberClass(), getLiter(), id);
        }
        public override string[] View()
        {
            string[] temp = new string[7];
            temp[0] = getFio();
            temp[1] = getMale();
            temp[2] = getBirth();
            temp[3] = getPhone();
            temp[4] = getAdress();
            temp[5] = getNumberClass().ToString();
            temp[6] = getLiter();

            return temp;
        }
        public override void Delete()
        {

        }

    }
}
