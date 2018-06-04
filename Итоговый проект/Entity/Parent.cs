using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект
{
    public class Parent : Person
    {
        string Proximity { get; set; }
        string Position { get; set; }
        string Company { get; set; }

        public string getProximity()
        {
            return Proximity;
        }
        public string getPosition()
        {
            return Position;
        }
        public string getCompany()
        {
            return Company;
        }
        public Parent()
        {
            Proximity = "";
            Position = "";
            Company = "";
        }
        public Parent(string fio, string proximity, string birth, string phone, string adress, string position, string company)
            : base(fio, birth, adress, phone)
        {
            Proximity = proximity;
            Position = position;
            Company = company;
        }

        public override void Add()
        {
            ControlDatabase par = new ControlDatabase();
            par.Add(getFio(), getProximity(), getBirth(), getPhone(), getAdress(), getPosition(), getCompany());
        }
        public override void Update(int id)
        {
            ControlDatabase control = new ControlDatabase();
            control.Update(getFio(), getProximity(), getBirth(), getPhone(), getAdress(), getPosition(), getCompany(), id);
        }
        public override string[] View()
        {
            string[] temp = new string[7];
            temp[0] = getFio();
            temp[1] = getProximity();
            temp[2] = getBirth();
            temp[3] = getPhone();
            temp[4] = getAdress();
            temp[5] = getPosition();
            temp[6] = getCompany();

            return temp;
        }
        public override void Delete()
        {

        }
    }
}
