using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект
{
    [Serializable]
    public abstract class Person
    {
        string Fio { get; set; }
        string Birth { get; set; }
        string Adress { get; set; }
        string Phone { get; set; }

        protected Person()
        {
            Fio = "";
            Birth = "";
            Adress = "";
            Phone = "";
        }
        protected Person(string fio, string birth, string adress, string phone)
        {
            Fio = fio;
            Birth = birth;
            Adress = adress;
            Phone = phone;
        }
        public string getFio()
        {
            return Fio;
        }
        public string getAdress()
        {
            return Adress;
        }
        public string getBirth()
        {
            return Birth;
        }
        public string getPhone()
        {
            return Phone;
        }

        public abstract void Add();
        public abstract string[] View();
        public abstract void Update(int id);
        public abstract void Delete();
    }
}
