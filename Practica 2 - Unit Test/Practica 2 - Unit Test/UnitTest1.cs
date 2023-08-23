using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Practica_2___Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivCero()
        {
            TestDivisionPorCero.TestDivisionCero(10);
        }

        [TestMethod]
        public void TestDivisionPorConsola()
        {
            // este bloque simula la entrada del 10 y el 0 como dividendo y divisor respectivamente
            using (StringReader sr = new StringReader("10\n0\n")) 
            {
                Console.SetIn(sr);

                TestDivisionDosNum TestDiv = new TestDivisionDosNum();
                TestDiv.Division();
            }
        }

        [TestMethod]
        public void Logic()
        {
            Logic logic = new Logic();

            try
            {
                logic.GenerarExcepcion();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Mensaje: {ex.Message}");
                Console.WriteLine("Tipo de excepción: " + ex.GetType());
            }
        }

        [TestMethod]
        public void ExcPersonalizada()
        {
            CustomLogic cLogic = new CustomLogic();

            try
            {
                cLogic.GenerarMiExcepcion();
            }
            catch(CustomException ex)
            {
                Console.WriteLine($"Se capturo la custom exception: '{ex.Message}'");
            }
            finally
            {
                Console.WriteLine("Siempre que tengas un 'finally' va a pasar bajo cualquier circunstancia");
            }
        }
    }
}
