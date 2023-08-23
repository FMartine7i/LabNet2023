using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practica_2___Unit_Test
{
    public class TestDivisionPorCero
    {
        public static void TestDivisionCero(int Dividendo)
        {
            try
            {
                int Divisor = 0;

                int Resultado = Dividendo / Divisor;

                Assert.Fail("La división por cero no generó la excepción esperada");
            }
            catch(DivideByZeroException ex)
            {
                Assert.AreEqual("Attempted to divide by zero.", ex.Message);

                Console.WriteLine($"La operación generó una excepción: {ex.Message}");
            }
            catch (Exception)
            {
                Assert.Fail("Se generó una excepción diferente a DivideByZeroException.");
            }
        }
    }
}
