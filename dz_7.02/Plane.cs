using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7._02
{
    public class Plane
    {
        private string name { get; set; }
        private static string manufacturer;
        private int year { get; set; }
        private string type { get; set; }
        
        public Plane()
        {

        }
        public Plane(string n, int y,string t)
        {
            name = n;
            year = y;
            type = t;
        }
        static Plane()
        {
            Console.Write("Введите производителя: ");
            manufacturer = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine($"Name: {name};\nManufacturer: {manufacturer};\nYear: {year};\nType: {type}.");
        }
        public override string ToString()
        {
            return $"Name: {name};\nManufacturer: {manufacturer};\nYear: {year};\nType: {type}.";
        }
    }
}
