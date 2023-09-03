using MiTest.Exceptions;
using System;

namespace MiTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test metodo Add");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Ingrese una ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un nombre para una categoría: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese una descripción: ");
            string description = Console.ReadLine();

            Logic.TestAddCategory(id, name, description);
        }
    }
}
