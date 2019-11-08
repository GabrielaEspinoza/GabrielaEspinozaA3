using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GabrielaEspinoza3A

namespace Cola._02
{
    class Colas
    {
        static void Main(string[] args)
        {
            Queue<int> cola = new Queue<int>();
            int boton;
            do
            {
                Console.WriteLine(" Opciones:");
                Console.WriteLine(" 1.- Añadir. ");
                Console.WriteLine(" 2.- Eliminar. ");
                Console.WriteLine(" 3.- Mostrar cuantos elementos hay en la Cola.");
                Console.WriteLine(" 4.- Salir. ");
                Console.WriteLine("Ingresar opcion: ");
                switch (boton)
                {
                    case 1:
                        Añadir(ref cola);
                        break;
                    case 2:
                        Eliminar(ref cola);
                        break;
                    case 3:
                        MostrarCola(ref cola);
                        break;
                    case 4:
                        break;

                }

            } while (opcion != 4);

            Console.ReadKey();
        }

        public static void Añadir(ref Queue<int> lacola)
        {
            Console.WriteLine("Ingrese valor:");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            lacola.Enqueue(numero1);
            Console.WriteLine(lacola);
        }

        public static void Eliminar(ref Queue<int> lacola)
        {
            int numero1 = (int)lacola.Dequeue();
            Console.WriteLine("Elemento" + numero1 + "eliminado");

            Console.WriteLine(lacola);

        }

        public static void MostrarCola(Queue<int> lacola)
        {

            Console.WriteLine("Hay" + lacola.Count + "elemento en la cola.");
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}

            

