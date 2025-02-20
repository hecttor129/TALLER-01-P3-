using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    class Ejercicio_3
    {
        public string nombre;
        public int edad;
        public char sexo;
        public float pulsaciones;

        public void CapturarDatos()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2); Console.WriteLine("C A L C U L O   D E   P U L S A C I O N E S");
            Console.SetCursorPosition(10, 4); Console.Write("nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(10, 5); Console.Write("edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 6); Console.Write("sexo (M/F): ");
            sexo = char.Parse(Console.ReadLine());
        }
        public float CalcularPulsaciones()
        {

            do
            {
                try
                {
                    if (edad < 0 || edad > 130)
                    {
                        Console.SetCursorPosition(16, 12); throw new Exception("Por favor, ingrese una edad válida. (desde 0 hasta 130)");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.SetCursorPosition(16, 8); Console.Write("edad: ");
                    edad = int.Parse(Console.ReadLine());
                }
            } while (edad < 0 || edad > 130);


            if (sexo == 'M' || sexo == 'm')
            {
                pulsaciones = (210 - edad) / 10;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pulsaciones = (220 - edad) / 10;
            }
            

            do
            {
                try
                {
                    if (sexo != 'M' && sexo != 'm' && sexo != 'F' && sexo != 'f')
                    {
                        Console.SetCursorPosition(16, 12); throw new Exception("Por favor, ingrese un sexo valido.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.SetCursorPosition(16, 10); Console.Write("sexo (M/F): ");
                    sexo = char.Parse(Console.ReadLine());
                }
            } while (sexo != 'M' && sexo != 'm' && sexo != 'F' && sexo != 'f');

            return pulsaciones;
        }

        public void ImprimirResultado()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2); Console.WriteLine("C A L C U L O   D E   P U L S A C I O N E S");
            Console.SetCursorPosition(10, 4); Console.WriteLine("RESULTADOS:");
            Console.SetCursorPosition(10, 5); Console.WriteLine("Nombre: " + nombre);
            Console.SetCursorPosition(10, 6); Console.WriteLine("Edad: " + edad);
            Console.SetCursorPosition(10, 7); Console.WriteLine("Sexo: " + sexo);
            Console.SetCursorPosition(10, 9); Console.WriteLine("Pulsaciones: " + pulsaciones +" Frecuenca :10/s");
            Console.ReadKey();


        }
    }
}

