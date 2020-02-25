using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverarzenal
{
    class Program
    {
        enum fegyverek {gránát , uzi , m4 , ak47};
        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.m4;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.ak47);
            foreach (fegyverek item in fegyvertár)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
