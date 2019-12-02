using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    abstract class PrintEdition : IComparable
    {
        public string[] names = { "Роман", "Виктор", "Вадим", "Максим", "Александр", "Евгений", "Владислав", "Данил", "Сергей", "Денис", "Матвей", "Кирилл" };
        public string[] surnames = { "Кузьмин", "Тимофеев", "Ермаков", "Мельников", "Архипов", "Капустин", "Лихачёв", "Андреев", "Журавлёв", "Трофимов", "Князев" };
        public Random rand = new Random();
        private int year, amountOfPages;
        public PrintEdition(int y, int aop)
        {
            Year = y;
            AmountOfPages = aop;
        }
        public PrintEdition()
        {
            Year = rand.Next(0, 2019);
            amountOfPages = rand.Next(10, 1500);
        }
        public int Year
        {
            get { return year; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Неверно введен год;");
                }
                else
                {
                    year = value;
                }
            }
        }
        public int AmountOfPages
        {
            get { return amountOfPages; }
            set { amountOfPages = value; }
        }
        public virtual void Show()
        {
            Console.WriteLine("Год: " + Year + "\nКол-во страниц: " + AmountOfPages + "\n");
        }

        public virtual int CompareTo(object obj)
        {
            PrintEdition a = (PrintEdition)obj;
            if (this.year < a.year) return -1;
            if (this.year > a.year) return 1;
            return 0;
        }
    }
}
