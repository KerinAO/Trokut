using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kateta1;
            int kateta2;
            int hipotenuza;

            Console.WriteLine("Unesi vrijednosti trokuta: ");
            kateta1 = Convert.ToInt32(Console.ReadLine());
            kateta2 = Convert.ToInt32(Console.ReadLine());
            hipotenuza = Convert.ToInt32(Console.ReadLine());

            double x = Math.Pow(hipotenuza, 2);
            double y = Math.Pow(kateta1, 2);
            double z = Math.Pow(kateta2, 2);

            if (Convert.ToBoolean(x=y+z))
            {
                Console.WriteLine("Trokut je pravokutan");
            }

            Console.ReadKey();
        }
    }
}
