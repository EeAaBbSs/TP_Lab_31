using System;

namespace TP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string info1, info2, info3, info4, info5;
            Console.WriteLine("Здание 1\n----------------\nClass Monster");
            Monster monster = new Monster("enemy");
            info1 = monster.Info();
            Console.WriteLine(info1);

            Console.WriteLine("\nClass Demon : Monster");
            Demon demon = new Demon("enemy", "feather", "bone");
            info2 = demon.Info();
            Console.WriteLine(info2);

            Console.WriteLine("\nClass Archon : Demon");
            Archon archon = new Archon("enemy", "feather", "bone", 300);
            info3 = archon.Info();
            Console.WriteLine(info3);

            Console.WriteLine("\nЗадание 2\n----------------\nClass Notebook");
            Notebook notebook = new Notebook(8);
            info4 = notebook.Info();
            Console.WriteLine(info4);

            CoveredNotebook covNote = new CoveredNotebook(11, "carton");
            info5 = covNote.Info();
            Console.WriteLine(info5);
        }
    }
}
