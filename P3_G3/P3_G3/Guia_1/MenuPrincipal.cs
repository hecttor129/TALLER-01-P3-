using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_1
{
    public class MenuPrincipal
    {
        private Ejercicio_1 ejercicio_1 = new Ejercicio_1();
        private Ejercicio_2 ejercicio_2 = new Ejercicio_2();
        private Ejercicio_3 ejercicio_3 = new Ejercicio_3();
        public void Menu()
        {
          
            
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10,2); Console.Write("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(12,4); Console.WriteLine("1. Sistema De Gestion De Estudiantes.");
                Console.SetCursorPosition(12, 5); Console.WriteLine("2. Gestion financiera.");
                Console.SetCursorPosition(12, 6); Console.Write("3. pulsaciones. ");
                Console.SetCursorPosition(12, 7); Console.Write("9. Salir. ");
                Console.SetCursorPosition(12, 19); Console.Write("digite una opcion: ");
                Console.SetCursorPosition(32, 19); op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:                        
                        ejercicio_1.MenuGestionEstudiante();
                        break;
                    case 2:
                        ejercicio_2.MenuFinanciero();
                        break;
                    case 3:
                        ejercicio_3.CapturarDatos();
                        ejercicio_3.CalcularPulsaciones();
                        ejercicio_3.ImprimirResultado();
                        break;
                    case 9:
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }

            } while (op!=9);

        }
    }
}
