using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Estructura
{
    class PedirDatos
    {
        public void PedirDatos1()
        {
            while (true)
            {


                Console.Write(":::::Ingrese valor:");



                if (Console.ReadLine() == "-1") { Console.WriteLine("SALIENDO..."); break; }
                else if (int.TryParse(Console.ReadLine(), out int _dato))
                {
                    switch (_dato)
                    {
                        case 1:
                            Console.WriteLine("Opcion 1");
                            break;
                        case 2:
                            Console.WriteLine("Opcion 2");
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta");
                            break;
                    }

                }
                else Console.WriteLine("NO INGRESO UN VALOR CORRECTO");


            }
        }


        public void PedirDatos2()
        {



            Console.WriteLine(":::::PROGRAMA ALGORITMO ENTRADA");
            Console.WriteLine(":::::(-1) Para salir");

            while (true)
            {

                Console.Write("\n\n:::::Ingrese numero: ");
                string dato = Console.ReadLine();

                if (dato == "-1")
                {
                    Console.WriteLine("FIN DEL PROGRAMA"); break;
                }
                else if (int.TryParse(dato, out int int_dato))
                {
                    Console.WriteLine($"Numero correcto ingresado es: {int_dato}"); break;
                }
                else Console.WriteLine("NUMERO INCORRECTO"); continue;
            }
        }

    }
}
