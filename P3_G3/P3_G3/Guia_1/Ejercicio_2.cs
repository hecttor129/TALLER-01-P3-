using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guia_1
{
    class Ejercicio_2
    {
        public float consignar, retirar, saldo = 0;
        public string nombre, cuenta;


    private void Consignar()
        {
            Console.Clear();
            ImprimirCuenta();
            do
            {
                Console.SetCursorPosition(10, 2); Console.WriteLine("S I S T E M A  D E  C O N S I G N A C I O N");
                Console.SetCursorPosition(10, 4); Console.WriteLine("Digite La Cantidad a Consignar: ");
                Console.SetCursorPosition(10, 5); consignar = float.Parse(Console.ReadLine());
                if (consignar < 0)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("No Puede Consignar Una Cantidad Menor a Cero");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                                             ");
                }
                else
                {
                    saldo += consignar;
                }
            }while (consignar < 0);

            ImprimirCuenta();
            Console.ReadKey();
        }

        private void Retirar()
        {
            Console.Clear();
            ImprimirCuenta();
            bool retiro = false;
            do
            {
           
                Console.SetCursorPosition(10, 2); Console.WriteLine("S I S T E M A  D E  R E T I R O");
                Console.SetCursorPosition(10, 4); Console.WriteLine("Digite La Cantidad Que Desea Retirar");
                Console.SetCursorPosition(10, 5); retirar = float.Parse(Console.ReadLine());

                if (retirar > saldo)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("No Puede Retirar Mas Dinero De Lo Que Tiene");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                                             ");
                    
                    
                }
                else if (retirar < 0)
                {
                    Console.SetCursorPosition(10, 14); Console.WriteLine("No Puede Retirar Una Cantidad Menor a Cero");
                    Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                    Console.SetCursorPosition(10, 14);
                    Console.ReadKey();
                    Console.SetCursorPosition(10, 14); Console.WriteLine("                                             ");
                    retiro = false;
                }
                else
                {
                    saldo -= retirar;
                    retiro = true;
                    ImprimirCuenta();
                    Console.ReadKey();
                }
            } while (retiro == false);

            return;
        }

        private void ImprimirCuenta()
        {
            Console.SetCursorPosition(70, 2); Console.WriteLine("                             ");
            Console.SetCursorPosition(70, 3); Console.WriteLine("                             ");
            Console.SetCursorPosition(70, 4); Console.WriteLine("                             ");
            Console.SetCursorPosition(70, 5); Console.WriteLine("                             ");
            Console.SetCursorPosition(70, 6); Console.WriteLine("                             ");
            Console.SetCursorPosition(70, 7); Console.WriteLine("                             ");
        
            Console.SetCursorPosition(70, 2); Console.WriteLine("- C U E N T A -");
            Console.SetCursorPosition(70, 3); Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(70, 4); Console.WriteLine("Numero De Cuenta: " + cuenta);
            Console.SetCursorPosition(70, 5); Console.WriteLine("Nombre: " + nombre);
            Console.SetCursorPosition(70, 6); Console.WriteLine("Saldo Actual :" + saldo.ToString("f2"));
            Console.SetCursorPosition(70, 7); Console.WriteLine("-----------------------------");
            Console.SetCursorPosition(10, 6);
        }

        private void IngresarDatos()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 2); Console.WriteLine("I N G R E S O  D E  D A T O S");
            Console.SetCursorPosition(12, 4); Console.WriteLine("Ingrese Su Numero De Cuenta :");
            Console.SetCursorPosition(12, 5); cuenta = Console.ReadLine();
            Console.SetCursorPosition(12, 6); Console.WriteLine("Ingrese Su Nombre :");
            Console.SetCursorPosition(12, 7); nombre = Console.ReadLine();
            Console.SetCursorPosition(12, 8); Console.WriteLine("Digite Su Saldo Actual :");
            Console.SetCursorPosition(12, 9); saldo = float.Parse(Console.ReadLine());
        }

        public void MenuFinanciero()
        {
            IngresarDatos();    
            int op;
            do
            {
                Console.Clear();
                ImprimirCuenta();
                Console.SetCursorPosition(10, 2); Console.WriteLine("S I S T E M A  F I N A N C I E R O");
                Console.SetCursorPosition(12, 4); Console.WriteLine("1. Consignar");
                Console.SetCursorPosition(12, 5); Console.WriteLine("2. Retirar");
                Console.SetCursorPosition(12, 6); Console.WriteLine("3. salir");
                Console.SetCursorPosition(12, 7); Console.WriteLine("Digite Una Opcion");
                Console.SetCursorPosition(12, 8); op = int.Parse(Console.ReadLine());
               
                switch (op)
                    {
                    case 1:
                        Consignar();
                        break;
                    case 2:
                        Retirar();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.SetCursorPosition(10, 14); Console.WriteLine("Ingrese Una Opcion Valida");
                        Console.SetCursorPosition(10, 5); Console.WriteLine("     ");
                        Console.SetCursorPosition(10, 14);
                        Console.ReadKey();
                        Console.SetCursorPosition(10, 14); Console.WriteLine("                            ");
                        break;
                }
            } while (op != 3);



        }

    }
}
