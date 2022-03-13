using System;

namespace TP_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здание 1\nClass Monster");
            Monster monster = new Monster();
            monster.Info();

            Console.WriteLine("\nClass Demon : Monster");
            Demon demon = new Demon();
            demon.Info();
            demon.CanFly(); 
            demon.HaveHorns();

            Console.WriteLine("\nClass Archon : Demon");
            Archon archon = new Archon();
            archon.Info(); 
            archon.CanFly();
            archon.HaveHorns();
            archon.IsSmart();

            Console.WriteLine("\nЗадание 2");
            CoveredNotebook covNote = new CoveredNotebook();
            covNote.OpenBook();
        }
    }
}
