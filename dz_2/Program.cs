using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz_7._02;

namespace dz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employet[] employees = new Employet[2];
            employees[0] = new Employet("Dima", "22.07.2004", "night2spark@gmail.com", "CEO", "Main Proger"); 
            employees[1] = new Employet("Nikita", "10.02.2004", "n_mokseni@gmail.com", "CO-CEO", "Proger");
            Console.WriteLine(employees[0] + "\n");
            Console.WriteLine(employees[1]);
            Console.WriteLine("\n");

            Plane[] planes = new Plane[2];
            planes[0] = new Plane("F-16", 2016, "Штурм");
            planes[1] = new Plane("F-18", 2021, "Штурм");
            Console.WriteLine(planes[0] + "\n");
            Console.WriteLine(planes[1]);
            Console.WriteLine("\n");

            Matrix a = new Matrix();
            Console.WriteLine();
            Console.WriteLine(a);
        }
    }
}
