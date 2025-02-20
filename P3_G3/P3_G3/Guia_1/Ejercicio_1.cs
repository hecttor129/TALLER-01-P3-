using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class Ejercicio_1
    {
        //constantes
        const float PORC_NOTA1 = 0.3F;
        const float PORC_NOTA2 = 0.3F;
        const float PORC_NOTA3 = 0.4F;

        //lista
        List<string> estudiantes = new List<string>();

        //variables
        public string nombre, apellido, id;
        public float nota1, nota2,nota3, prom;
        
        //funciones
        public void CapturarNotas()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2); Console.WriteLine("S I S T E M A   D E   G E S T I O N   D E   N O T A S");

            do
            {
                Console.SetCursorPosition(10, 4); Console.Write("NOTA 1: ");
                Console.SetCursorPosition(10, 5); nota1 = float.Parse(Console.ReadLine());
                if (nota1 < 0 || nota1 > 5)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("Ingrese Una Nota Valida");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                            ");

                }
            } while (nota1 < 0 || nota1 > 5);

            do
            {
                Console.SetCursorPosition(10, 6); Console.Write("NOTA 2: ");
                Console.SetCursorPosition(10, 7); nota2 = float.Parse(Console.ReadLine());
                if (nota2 < 0 || nota2 > 5)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("Ingrese Una Nota Valida");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                            ");
                }
            } while (nota2 < 0 || nota2 > 5);

            do
            {
                Console.SetCursorPosition(10, 8); Console.Write("NOTA 3: ");
                Console.SetCursorPosition(10, 9); nota3 = float.Parse(Console.ReadLine());
                if (nota3 < 0 || nota3 > 5)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("Ingrese Una Nota Valida");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                            ");
                }
            } while (nota3 < 0 || nota3 > 5);

            Console.SetCursorPosition(10, 13); Console.WriteLine("Datos Registrados Correctamente");
            Console.ReadKey();

        }

        private float CalcularPromedio() => nota1 * PORC_NOTA1 + nota2 * PORC_NOTA2 + nota3 * PORC_NOTA3;
      
        private string EstadoEstudiante()
        {
            if (CalcularPromedio()>=3)
            {
                return "Eres un Estudiante Feliz ..."; 
            }
            return "Siga intentando ser Feliz ...";
        }

        private void ImprimirResultado()
        {
            Console.Clear();
            Console.WriteLine("SISTEMA DE GESTION DE NOTAS");
            Console.WriteLine("Nombre: ");
            Console.Write(nombre);
            Console.WriteLine("Primer Parcial: ");
            Console.Write(nota1.ToString("f1"));
            Console.Write("Segundo Parcial ");
            Console.WriteLine(nota2.ToString("f1"));
            Console.Write("Examen Final ");
            Console.WriteLine(nota3.ToString("f1"));
            Console.Write("DEfinitiva ");
            Console.WriteLine(CalcularPromedio().ToString("f1"));
            Console.WriteLine(EstadoEstudiante());

            Console.ReadKey();
        }

        private void PedirDatos()
        {

            Console.Clear();
            Console.SetCursorPosition(10, 2); Console.WriteLine("R E G I S T R O  D E  D A T O S");
            Console.SetCursorPosition(10, 4); Console.WriteLine("Identificacion: ");
            Console.SetCursorPosition(10, 5); id = Console.ReadLine();
            Console.SetCursorPosition(10, 6); Console.Write("Nombre Estudiante: ");
            Console.SetCursorPosition(10, 7); nombre = Console.ReadLine();
            Console.SetCursorPosition(10, 8); Console.Write("Apellido Estudiante: ");
            Console.SetCursorPosition(10, 9); apellido = Console.ReadLine();
            CapturarNotas();
            prom = CalcularPromedio();

            estudiantes.Add(id + " " + nombre + " " + apellido + " " + prom.ToString("f1"));
        }

        private void ImprimirLista()
        {
            Console.Clear();
            if (estudiantes.Count ==0)
            {
                Console.SetCursorPosition(10, 4); Console.WriteLine("No Hay Estudiantes Resgistrados");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("  L I S T A D O  D E  E S T U D I A N T E S");
            Console.WriteLine("  -----------------------------------------\n");
            


            foreach (string estudiante in estudiantes)
            {
                string[] datos = estudiante.Split(' ');

                Console.WriteLine("ID: "+datos[0]+"\nNOMBRE: " + datos[1]+"\nAPELLIDO: " + datos[2]+"\nPROMEDIO: " + datos[3]);
                Console.WriteLine("-------------------------------------------------------");
            }
            Console.ReadKey();

        }

        private void actualizar()
        {
            Console.Clear();
            if (estudiantes.Count == 0)
            {
                Console.SetCursorPosition(10, 4); Console.WriteLine("No Hay Estudiantes Resgistrados");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.SetCursorPosition(10, 2); Console.WriteLine("A C T U A L I Z A C I O N   D E   D A T O S");

            Console.SetCursorPosition(10, 4); Console.WriteLine("Digite La ID a Actualizar: ");
            Console.SetCursorPosition(10, 5); string id = Console.ReadLine();

            
            for (int i = 0; i < estudiantes.Count; i++)
            {
                string[] datos = estudiantes[i].Split(' ');
                if (datos[0] == id)
                {
                    Console.SetCursorPosition(10, 4); Console.WriteLine("                                          ");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("------------------------------------------");
                    Console.SetCursorPosition(10, 6); Console.WriteLine("Nombre Actual: " + datos[1]);
                    Console.SetCursorPosition(10, 7); Console.Write("Nuevo Nombre: "); nombre = Console.ReadLine();
                    Console.SetCursorPosition(10, 8); Console.WriteLine("Apellido Actual: " + datos[2]);
                    Console.SetCursorPosition(10, 9); Console.Write("Nuevo Apellido: "); apellido = Console.ReadLine();
                    CapturarNotas();
                    prom = CalcularPromedio();
                    estudiantes[i] = id + " " + nombre + " " + apellido + " " + prom.ToString("f1");
                    Console.ReadKey();

                }
                else
                {
                    Console.SetCursorPosition(10, 4); Console.WriteLine("                                           ");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("                                           ");
                    Console.SetCursorPosition(10, 4); Console.WriteLine("ID No Encontrada");
                    Console.ReadKey();
                }
            }
        }

        private void eliminar()
        {
            Console.Clear();
            if (estudiantes.Count == 0)
            {
                Console.SetCursorPosition(10, 4); Console.WriteLine("No Hay Estudiantes Resgistrados");
                Console.ReadKey();
                Console.Clear();
                return;
            }
            Console.SetCursorPosition(10, 2); Console.WriteLine("E L I M I N A C I O N   D E   D A T O S");
            Console.SetCursorPosition(10, 4); Console.WriteLine("Digite La ID a Eliminar: ");
            Console.SetCursorPosition(10, 5); string id = Console.ReadLine();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                string[] datos = estudiantes[i].Split(' ');
                if (datos[0] == id)
                {
                    Console.SetCursorPosition(10, 4); Console.WriteLine("                                          ");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("------------------------------------------");
                    Console.SetCursorPosition(10, 6); Console.WriteLine("Nombre: " + datos[1]);
                    Console.SetCursorPosition(10, 7); Console.WriteLine("Apellido: " + datos[2]);
                    Console.SetCursorPosition(10, 8); Console.WriteLine("Promedio: " + datos[3]);
                    Console.SetCursorPosition(10, 13); Console.WriteLine("                                  ");
                    Console.SetCursorPosition(10, 13); Console.WriteLine("Datos Eliminados Correctamente");
                    Console.ReadKey();
                    estudiantes.RemoveAt(i);
                }
                else
                {
                    Console.SetCursorPosition(10, 4); Console.WriteLine("                                           ");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("                                           ");
                    Console.SetCursorPosition(10, 4); Console.WriteLine("ID No Encontrada");
                    Console.ReadKey();
                }
            }
        }

        public void MenuGestionEstudiante()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 2); Console.WriteLine("S I S T E M A   D E   G E S T I O N   D E   E S T U D I A N T E S");
                Console.SetCursorPosition(12, 4); Console.WriteLine("1. Agregar Estudiante");
                Console.SetCursorPosition(12, 5); Console.WriteLine("2. Actualizar Estudiante");
                Console.SetCursorPosition(12, 6); Console.WriteLine("3. Eliminar Estudiante");
                Console.SetCursorPosition(12, 7); Console.WriteLine("4. Ver Lista Estudiantes");
                Console.SetCursorPosition(12, 8); Console.WriteLine("5. Salir");
                Console.SetCursorPosition(12, 12); Console.Write("Digite una Opcion: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        PedirDatos();
                        break;
                    case 2:
                        actualizar();
                        break;
                    case 3:
                        eliminar();
                        break;
                    case 4:
                        ImprimirLista();
                        break;
                }
            } while (op != 5);
        }


    }
}
