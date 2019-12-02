using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Magazine: PrintEdition
    {
        private string theme;
        private int month;
        private string[] themes = { "Программирование", "Комиксы", "Автомобили", "Компьютерные игры", "Рыбалка", "Компьютеры", "Спорт", "Новости" };
        public int Month
        {
            get { return month; }
            set
            {
                while (value > 12 || value < 1)
                {
                    Console.WriteLine("В году 12 месяцев. Повторите ввод");
                    value = Int32.Parse(Console.ReadLine());
                }
                month = value;
            }
        }
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }
        public Magazine(int y, int aofp, int m,string t):
            base(y,aofp)
        {
            Month = m;
            Theme = t;
        }
        public Magazine():
            base()
        {
            Month = rand.Next(1, 12);
            Theme = themes[rand.Next(0, themes.Length)];
        }
        public override void Show()
        {
            Console.WriteLine("Год: " + Year + "\nКол-во страниц: " + AmountOfPages);
            Console.WriteLine("Месяц: " + month + "\nТема: " + theme + "\n");
        }
        public int Compare(object obj)
        {
            Magazine a = (Magazine)obj;
            if (this.Month > a.Month) return 1;
            if (this.Month < a.Month) return -1;
            return 0;
        }
    }
    public class SortByMonth : IComparer<Magazine>
    {
        int IComparer<Magazine>.Compare(Magazine x, Magazine y)
        {
            return x.Compare(y);
        }

    }
}