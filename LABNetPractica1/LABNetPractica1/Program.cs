using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LABNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            List<TransportePublico> transportes = new List<TransportePublico>();

            int CantOmnibus = 0;
            int CantTaxis = 0;
            while (CantOmnibus < 5 || CantTaxis < 5)
            {
                Console.WriteLine("¿Qué tipo de transporte desea agregar? (Omnibus/Taxi): ");
                string TipoTransporte = Console.ReadLine().ToLower();

                if (TipoTransporte != "omnibus" && TipoTransporte != "taxi")
                    Console.WriteLine("Error. Debe ingresar un string válido.");
                else
                {
                    if (TipoTransporte == "omnibus" && CantOmnibus < 5)
                    {
                        int cantPasajeros = ValidarPasajeros(TipoTransporte);
                        Omnibus omnibus = new Omnibus(cantPasajeros);
                        transportes.Add(omnibus);
                        CantOmnibus++;
                    }
                    else if (TipoTransporte == "taxi" && CantTaxis < 5)
                    {
                        int cantPasajeros = ValidarPasajeros(TipoTransporte);
                        Taxi taxi = new Taxi(cantPasajeros);
                        transportes.Add(taxi);
                        CantTaxis++;
                    }
                    else
                        Console.WriteLine("Error. No se pueden agregar más transportes de este tipo.");
                }
               
            }

            Console.WriteLine("\n\nCantidad de Pasajeros de cada transporte\n");

            foreach(var transporte in transportes)
            {
                string Transporte = transporte.Tipo;
                Console.WriteLine($"{Transporte} {transporte.Num}: {transporte.CantPasajeros} pasajeros");
                Console.WriteLine(transporte.Avanzar());
                Console.WriteLine(transporte.Detenerse());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        private static int ValidarPasajeros(string TipoTransporte)
        {
            int num = -1;
            bool numEsValido = false;

            while (!numEsValido)
            {
                if (TipoTransporte == "omnibus")
                {
                    Console.WriteLine("Se permite ingresar de 1 a 100 pasajeros.");
                }
                else if (TipoTransporte == "taxi")
                {
                    Console.WriteLine("Se permite ingresar de 1 a 4 pasajeros.");
                }

                Console.WriteLine($"Ingrese cantidad de pasajeros para {TipoTransporte}: ");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (TipoTransporte == "omnibus" && (num < 1 || num > 100))
                    {
                        Console.WriteLine("Se debe ingresar un número dentro del rango permitido.");
                    }
                    else if (TipoTransporte == "taxi" && (num < 1 || num > 4))
                    {
                        Console.WriteLine("Se debe ingresar un número dentro del rango permitido.");
                    }
                    else
                    {
                        numEsValido = true;
                    }
                }
            }
            return num;
        }
    }
}
