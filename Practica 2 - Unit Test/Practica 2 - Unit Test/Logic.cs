using System;

namespace Practica_2___Unit_Test
{
    public class Logic
    {
        public void GenerarExcepcion()
        {

            throw new DivideByZeroException("Esta es una excepcion del tipo DivideByZero");

        }
    }
}
