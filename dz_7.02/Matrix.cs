using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7._02
{
    public class Matrix
    {
        private static int rows;
        private static int cols;
        private int[,] mass = new int[rows, cols];
        private int min { get; set; } = 0;
        private int max { get; set; } = 0;
        public Matrix()
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    mass[i, j] = random.Next(1, 20);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    if (min > mass[i, j])
                        min = mass[i, j];
                    if (max < mass[i, j])
                        max = mass[i, j];
                }
        }

        static Matrix()
        {
            Console.Write("Введите кол-во строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            cols = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(mass[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine($"Min: {min};\nMax: {max}");
        }

        public override string ToString()
        {
            Print();
            return "";
        }
    }
}
