using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverarzenal
{
    class Program
    {
        enum fegyverek { Uzi, M4, Gránát, Lánszóró, AK47, Shotgun, }

        static void Main(string[] args)
        {
            List<fegyverek> fegyvertáska = new List<fegyverek>();
            // Egy fegyvert csak egy példányban tárolhatunk.
            Felpakol(fegyvertáska); //Az összes fegyvert berakja a fegyvertárba.
            Kivesz(fegyvertáska, fegyverek.Shotgun);   //Egy konkrét fegyvert kivesz a fegyvertárból.
            Felvesz(fegyvertáska, fegyverek.Shotgun);  //Egy fegyvert betesz a fegyvertár végére.
            Felvesz_2(fegyvertáska, fegyverek.Shotgun);//Egy fegyvert berak i. helyre
            Kiürít(fegyvertáska);   //Kiüríti a fegyvertárat.
            int db = Fegyverszám(fegyvertáska); // Visszaadja hány fegyver van a fegyvertárban.
            Listázó(fegyvertáska);  //Kiírja milyen fegyverek vannak nálam.
            Console.ReadKey();
        }

        private static int Fegyverszám(List<fegyverek> fegyvertáska)
        {
            int db = fegyvertáska.Count;
            Console.WriteLine($"{db} fegyver van nálad.");
            return db;
        }

        static void Kiürít(List<fegyverek> fegyvertáska)
        {
            fegyvertáska.Remove(fegyverek.Shotgun);
            fegyvertáska.Remove(fegyverek.Uzi);
            fegyvertáska.Remove(fegyverek.M4);
            fegyvertáska.Remove(fegyverek.Gránát);
            fegyvertáska.Remove(fegyverek.Lánszóró);
            fegyvertáska.Remove(fegyverek.AK47);
            Listázó(fegyvertáska);
        }

        static void Felvesz_2(List<fegyverek> fegyvertáska, fegyverek Shotgun)
        {
            if (!fegyvertáska.Contains(fegyverek.Shotgun))
            {
                fegyvertáska.Insert(0, fegyverek.Shotgun);
                Listázó(fegyvertáska);
            }

        }

        static void Felvesz(List<fegyverek> fegyvertáska, fegyverek Shotgun)
        {
            if (!fegyvertáska.Contains(fegyverek.Shotgun))
            {
                fegyvertáska.Add(fegyverek.Shotgun);
                Listázó(fegyvertáska);
            }
        }

        static void Kivesz(List<fegyverek> fegyvertáska, fegyverek Shotgun)
        {
            fegyvertáska.Remove(fegyverek.Shotgun);
            Listázó(fegyvertáska);
        }

        static void Listázó(List<fegyverek> fegyvertáska)
        {
            Console.WriteLine("Fegyvertáska: ");
            foreach (fegyverek elem in fegyvertáska)
            {
                Console.Write(elem + ", ");
            }
        }

        static void Felpakol(List<fegyverek> fegyvertáska)
        {
            fegyvertáska.Add(fegyverek.AK47);
            fegyvertáska.Add(fegyverek.Uzi);
            fegyvertáska.Add(fegyverek.M4);
            fegyvertáska.Add(fegyverek.Gránát);
            fegyvertáska.Add(fegyverek.Lánszóró);
            fegyvertáska.Add(fegyverek.Shotgun);
            Listázó(fegyvertáska);
        }
    }
}
