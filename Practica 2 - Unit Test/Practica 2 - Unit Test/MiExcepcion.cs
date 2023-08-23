using System;

namespace Practica_2___Unit_Test
{
    public class CustomException : Exception
    {
        public CustomException(string Mensaje) : base(Mensaje)
        {

        }
    }

    public class CustomLogic
    {
        public void GenerarMiExcepcion()
        {
            throw new CustomException("Yo creé esta exception");
        }
    }
}
