using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practica_2___Unit_Test
{
    public class TestDivisionDosNum
    {
        public void Division()
        {

            try
            {
                Console.WriteLine("Ingrese el dividendo: ");
                double Dividendo = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor: ");

                double Divisor = double.Parse(Console.ReadLine());

                if (Divisor == 0)
                    throw new DivideByZeroException("Solo Chuck Norris divide por cero!");
                else { 
                    double resultado = Dividendo / Divisor;
                    Console.WriteLine("El resultado de la división es: " + resultado);
                }             
            }
            catch (FormatException)
            {
                Assert.Fail("¡Seguro ingresó una letra o no ingresó nada!");
            }
        }
    }
}
