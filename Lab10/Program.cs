using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Lab10
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВИРТУАЛЬНЫЕ МЕТОДЫ И ИЕРАРХИЯ КЛАССОВ, ЗАПРОСЫ\n");
            List<PrintEdition> arr = new List<PrintEdition>();
            AutoFill(arr,5);
            arr.Sort();
            ShowItems(arr);
            ShowAmountOfProgrammingMagazines(arr);
            Console.WriteLine("\n\nИНТЕРФЕЙСЫ\n");
            Magazine[] mas = new Magazine[5];
            MagazineArrayFill(mas);
            Array.Sort(mas, new SortByMonth());
            MagazineShow(mas);
            WorkWithClone();
        }
        public static void ShowItems(List<PrintEdition> a)
        {
            foreach (PrintEdition item in a)
            {
                item.Show();
            }
        }
        public static void AutoFill(List<PrintEdition> a, int size)
        {
            Random rand = new Random();
            while (a.Count < size)
            {
                Thread.Sleep(20);
                int r = rand.Next(1, 4);
                switch (r)
                {
                    case 1:
                        book koob = new book();
                        a.Add(koob);
                        break;
                    case 2:
                        Textbook uchebnik = new Textbook();
                        a.Add(uchebnik);
                        break;
                    case 3:
                        Magazine jurnal = new Magazine();
                        a.Add(jurnal);
                        break;
                }
            }
        }
        public static void ShowBookWithMaxPages(List<PrintEdition> a)
        {
            int max = 0;
            int index = -1;
            int count = 0;
            book f;
            foreach (PrintEdition item in a)
            {
                f = item as book;
                if (f != null)
                {
                    if (f.AmountOfPages > max)
                    {
                        max = f.AmountOfPages;
                        index = count;
                    }
                }
                count++;
            }
            if (index >= 0)
            {
                Console.WriteLine("Книга с максимальным количеством страниц: \n");
                a[index].Show();
            }
            else
            {
                Console.WriteLine("В коллекции нет книг");
            }
        }
        public static void ShowAmountOfProgrammingMagazines(List<PrintEdition> a)
        {
            int count = 0;
            Magazine p;
            foreach(PrintEdition item in a)
            {
                p = item as Magazine;
                if (p != null && p.Theme == "Программирование")
                {
                    count++;
                }
            }
            Console.WriteLine("Количество журналов по программированию: "+count);
        }
        public static void ShowEverythingYoungerThan(List<PrintEdition> a, int ye)
        {
            Console.WriteLine("Все печатные издания новее, чем " + ye + ":\n");
            int count = 0;
            foreach (PrintEdition item in a)
            {
                if(item.Year > ye)
                {
                    item.Show();
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Таких книг нет\n");
            }
            
        }
        public static void MagazineArrayFill(Magazine[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Thread.Sleep(20);
                Magazine b = new Magazine();
                a[i] = b;
            }
        }
        public static void MagazineShow(Magazine[] a)
        {
            foreach (Magazine b in a)
            {
                b.Show();
            }
        }
        public static void WorkWithClone()
        {
            book[] bookarr = new book[3];
            bookarr[0] = new book();
            bookarr[1] = bookarr[0].ShallowCopy();
            bookarr[2] = (book)bookarr[0].Clone();
            foreach (book a in bookarr)
            {
                a.Show();
            }
        }
    }
}
