﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект.Plugins
{
    class FillDataBase // класс для случайного заполнения БД элементами
    {
        public void Fill(int limit)
        {
            int count = 0;
            while(count < limit)
            {
                ControlDatabase control = new ControlDatabase();
                Children children1 = new Children(GetFIO(), GetMale(), GetBirth(), GetPhone(), GetAdress(), GetNumber(), GetLiter());
                
                children1.Add();
                int IDch = control.GetLastID("Childrens");

                Parent _parent1 = new Parent(GetFIO(), GetProximity(), GetBirth(), GetPhone(), GetAdress(), GetPosition(), GetCompany());
                _parent1.Add();
                int IDpar1 = control.GetLastID("Parents");

                Parent _parent2 = new Parent(GetFIO(), GetProximity(), GetBirth(), GetPhone(), GetAdress(), GetPosition(), GetCompany());
                _parent2.Add();
                int IDpar2 = control.GetLastID("Parents");


                control.Add(IDch, IDpar1);
                control.Add(IDch, IDpar2);
                count++;
            }
        }
        public string GetFIO()
        {
            string[] FIO = { "Тимирёва Ангелина Несторовна",
                               "Быков Матвей Филиппович",
                               "Невский Зиновий Агапович",
                               "Рассказов Иосиф Тимурович",
                               "Ратаев Лаврентий Сидорович",
                               "Беломестина Марианна Василиевна",
                               "Краснова Аза Иосифовна",
                               "Хрущёв Зиновий Геннадиевич",
                               "Тарасова Роза Брониславовна",
                               "Баженов Евсей Брониславович",
                               "Капп Мстислав Игоревич",
                               "Созонтов Адриан Валериевич",
                               "Сафонова Дарья Петровна",
                               "Ураков Сократ Артемович",
                               "Жарикова Агния Родионовна",
                               "Чуркин Порфирий Владимирович",
                               "Романова Нона Яновна",
                               "Кутепов Тимофей Касьянович",
                               "Ясногородский Авдей Фомевич",
                               "Цой Анфиса Серафимовна",
                               "Ясько Елена Германовна",
                               "Поджио Наталья Тимофеевна",
                               "Заседателев Герман Ипатович",
                               "Игнатов Рюрик Онуфриевич",
                               "Гершковича Яна Всеволодовна",
                               "Чуринов Всеслав Ефремович",
                               "Шипицина Злата Фомевна",
                               "Бруевич Арсений Леонович",
                               "Суснин Тарас Кондратиевич",
                               "Путилин Владимир Евлампиевич",
                               "Каржов Карл Никонович",
                               "Кошелькова Яна Потаповна",
                               "Жиганова Роза Карповна",
                               "Ивашин Виталий Тарасович",
                               "Корниец Рюрик Юриевич",
                               "Яркова Евгения Ефимовна",
                               "Кожуров Валерьян Олегович",
                               "Пишенина Ника Ефимовна",
                               "Полякова Лиана Ильевна",
                               "Шишмарёв Чеслав Федотович",
                               "Коротаева Берта Якововна",
                               "Кучава Розалия Емельяновна",
                               "Шихина Аза Степановна",
                               "Зухин Моисей Назарович",
                               "Курсалина Владлена Евгениевна",
                               "Смагин Клавдий Брониславович",
                               "Халипова Инга Анатолиевна",
                               "Кулактина Лилия Олеговна",
                               "Голышев Мирон Измаилович",
                               "Лунина Милена Степановна",
                               "Крылов Александр Проклович",
                               "Клокова Злата Елизаровна",
                               "Койначёнок Лука Брониславович",
                               "Березин Семен Эмилевич",
                               "Яшихин Всеволод Леонтиевич",
                               "Косицкий Адриан Сидорович",
                               "Кярбера Анна Андрияновна",
                               "Ермишин Казимир Измаилович",
                               "Богачёв Лаврентий Зиновиевич",
                               "Баскаков Изяслав Афанасиевич",
                               "Андреева Алина Тимуровна",
                               "Огарков Мефодий Самсонович",
                               "Кузинков Сократ Тимурович",
                               "Умский Лукьян Саввевич",
                               "Кардапольцев Артем Михаилович",
                               "Хамидуллина Наталия Данииловна",
                               "Жвикова Эльвира Филипповна",
                               "Никишин Тимофей Адрианович",
                               "Белозеров Платон Сидорович",
                               "Хабалова Лидия Родионовна",
                               "Кувардина Владлена Леонидовна",
                               "Гулина Марианна Филипповна",
                               "Дёмшин Василий Адрианович",
                               "Лямин Платон Титович",
                               "Белозеров Всеслав Ростиславович",
                               "Колодезев Аскольд Егорович",
                               "Манторова Александра Иосифовна",
                               "Кручинкин Евграф Тимурович",
                               "Вотякова Елена Петровна",
                               "Шуршалина Анастасия Станиславовна",
                               "Телицына Ефросиния Ипполитовна",
                               "Яцкова Марина Мироновна",
                               "Сиянко Всеслава Захаровна",
                               "Овсов Семен Артемович",
                               "Бебнева Инга Ираклиевна",
                               "Таганцев Артём Панкратиевич",
                               "Ковпака Любовь Феликсовна",
                               "Ягунова Нина Георгиевна",
                               "Романова Валентина Василиевна",
                               "Другаков Адам Евграфович",
                               "Юрков Савелий Феоктистович",
                               "Мосяков Ипполит Венедиктович",
                               "Сунгатулина Эльвира Мефодиевна",
                               "Шушалева Доминика Игнатиевна",
                               "Грешнев Прокофий Фомевич",
                               "Хорьков Алексей Иосифович",
                               "Цейдлерина Доминика Ираклиевна",
                               "Яхин Семен Тихонович",
                               "Яимова Юнона Ефимовна",
                               "Колиух Якуб Григориевич", };
            Random rand = new Random();
            int i = rand.Next(0, 100);
            return FIO[i];
        }
        public string GetMale()
        {
            Random rand = new Random();
            int i = rand.Next(1, 10);
            if (i % 2 != 0)
                return "муж";
            else
                return "жен";
        }
        public string GetBirth()
        {
            StringBuilder birth = new StringBuilder();
            Random rand = new Random();
            int day = rand.Next(1, 30);
            int mounth = rand.Next(1, 12);
            int year = rand.Next(1980, 2005);
            if (day < 10)
            {
                birth.Append("0"); birth.Append(day); birth.Append(".");
            }
            else
            {
                birth.Append(day); birth.Append(".");
            }
            if (mounth < 10)
            {
                birth.Append("0"); birth.Append(mounth); birth.Append(".");
            }
            else
            {
                birth.Append(mounth); birth.Append(".");
            }

            birth.Append(year);
            return birth.ToString();
        }
        public string GetPhone()
        {
            StringBuilder phone = new StringBuilder();
            Random rand = new Random();
            phone.Append("+7(9");
            for (int i = 0; i < 2; i++)
            {
                phone.Append(rand.Next(0, 10));
            }
            phone.Append(")");
            for (int i = 0; i < 2; i++)
            {
                phone.Append(rand.Next(0, 10));
            }
            phone.Append("-");
            for (int i = 0; i < 2; i++)
            {
                phone.Append(rand.Next(0, 10));
            }
            phone.Append("-");
            for (int i = 0; i < 3; i++)
            {
                phone.Append(rand.Next(0, 10));
            }
            return phone.ToString();
        }
        public string GetAdress()
        {
            StringBuilder Adress = new StringBuilder();
            Adress.Append("г.Пермь, ул.");
            string[] Street = {"Акмолинская",
                               "Аксайская",
                               "Аксакова",
                               "Алексеевская",
                               "Алмазная",
                               "Бахчевая",
                               "Бахчисарайский",
                               "Башкирская",
                               "Башкова",
                               "Безымянная",
                               "Белая",
                               "Белгородская",
                               "Белебейская",
                               "Волочаевская",
                               "Волховская",
                               "Волынская",
                               "Вольская",
                               "Воркутинская",
                               "Воронежская",
                               "Восстания",
                               "Восточный",
                               "Гравийный 3 - й пер",
                               "Гравийный 4 - й пер",
                               "Гранильный пер",
                               "Граничная",
                               "Ленина",
                               "Графтио",
                               "Грачева",
                               "Гремячая",
                               "Гремячий лог",
                               "Гремячинская",
                               "Грибоедова",
                               "Железнодорожная",
                               "Комсомольский проспект",
                               "Желябова",
                               "Зеленая",
                               "Стахановская",
                               "Зеленина",
                               "Иркутская",
                               "Искорская",
                               "Каховская",
                               "Качалова",
                               "Качканарская",
                               "Каширинская" };         
            Random rand = new Random();
            int i = rand.Next(0, 44);
            Adress.Append(Street[i]);
            Adress.Append(", д.");
            Adress.Append(rand.Next(1, 100));
            Adress.Append(", кв.");
            Adress.Append(rand.Next(1, 444));
            return Adress.ToString();
        }
        public byte GetNumber()
        {
            Random rand = new Random();
            return (byte)rand.Next(1, 12);
        }
        public string GetLiter()
        {
            string[] mas = { "а", "б", "в", "г", "д", "е" };
            Random rand = new Random();
            return mas[rand.Next(0,6)];
        }
        public string GetProximity()
        {
            string[] mas = { "папа", "мама", "брат", "сестра", "бабушка", "дедушка" };
            Random rand = new Random();
            return mas[rand.Next(0, 6)];
        }
        public string GetCompany()
        {
            string[] mas = { "Гипсополлимер", "Билайн", "Торговая сеть", "Монетка", "Строительная компания", "Группа компаний \"Лион\"", "Дом.ru", "Алендвик", "Новомет", "СемьЯ, Сеть супермаркетов", "СтеклоДом", "ГБУЗ ПК ГДКП № 5" };
            Random rand = new Random();
            return mas[rand.Next(0, 12)];
        }
        public string GetPosition()
        {
            string[] mas = { "Инженер", "Менеджер по продажам", "Сантехник", "Директор", "Топограф", "Эколог", "Менеджер по привлечению клиентов", "Уборщица", "Технолог", "Супервайзер", "Программист", "Делопроизодитель" };
            Random rand = new Random();
            return mas[rand.Next(0, 12)];
        }
    }
}
