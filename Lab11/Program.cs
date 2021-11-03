using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения.\n");

            LinearEq lin;

            try
            {
                Console.Write("Введите коэффициент k: ");
                lin.k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение b: ");
                lin.b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\tСогласно введённым данным, переменная х составляет: " + lin.Root());
            }
            catch (FormatException)
            {
                Console.WriteLine("\nВведённое значение не является числом.");
            }
            //catch
            //{
            //    Console.WriteLine("\nУравнение с введёнными данными не имеет решения.");
            //}

            Console.ReadKey();
        }
    }

    struct LinearEq
    {
        public float k;
        public float b;

        public float Root()
        {
            float x = -b / k;
            if (k == 0 && !(b == 0))
                throw new Exception("ValueException");
            else
                return x;
        }
    }
}
