using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{

    class book: PrintEdition, ICloneable
    {
        private string[] titles = { "Моя спрятанная эра", "Моё невероятное одиночество", "Вечная весна", "Удачливое путешествие", "Личный обход", "Воровка для огненного вампира", "Откровения Нада",
        "Отражение потерянной крови", "Служанка неизвестного лорда", "Потрясающее решение"};
        private string title, author;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public book(int ye,int aofp,string t,string a) :
            base(ye,aofp)
        {
            Title = t;
            Author = a;
        }
        public book() :
            base()
        {
            Title = titles[rand.Next(0, titles.Length)];
            Author = names[rand.Next(0, names.Length)] + " " + surnames[rand.Next(0,surnames.Length)];
        }
        public override void Show()
        {
            Console.WriteLine("Год: " + Year + "\nКол-во страниц: " + AmountOfPages);
            Console.WriteLine("Название: " + Title + "\nАвтор: " + Author + "\n");
        }
        public book ShallowCopy() //поверхностное копирование
        {
            return (book)this.MemberwiseClone();
        }
        public object Clone()
        {
            return new book(this.Year,this.AmountOfPages,"Клон " + this.Title, this.Author);
        }
    }
}
