using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Textbook: PrintEdition
    {
        private string[] subjects = { "Математика", "Физика", "Биология", "Информатика", "Русский язык", "Английский язык", "Химия", "История", "Литература" };
        private string subject, author;
        public Textbook(int ye, int aofp,string sub, string a):
            base(ye,aofp)
        {
            Subject = sub;
            Author = a;
        }
        public Textbook():
            base()
        {
            Subject = subjects[rand.Next(0, subjects.Length)];
            Author = names[rand.Next(0, names.Length)] + " " + surnames[rand.Next(0, surnames.Length)];
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public override void Show()
        {
            Console.WriteLine("Год: " + Year + "\nКол-во страниц: " + AmountOfPages);
            Console.WriteLine("Предмет: " + Subject + "\nАвтор: " + Author + "\n");
        }
    }
}
