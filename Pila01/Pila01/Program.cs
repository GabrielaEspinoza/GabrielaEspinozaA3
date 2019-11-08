using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GabrielaEspinoza3A

namespace Pila01
{
    class Pilas
    {
        public static void Main(string[] args)
        {
            Stack<int> Pila= new Stack<int>();
            int Boton;
            do
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("0.- Mostar los elementos en la Pila.");
                Console.WriteLine("1.- Agregar elemento en la Pila.");
                Console.WriteLine("2.- Eliminar elemento en la Pila.");
                Console.WriteLine("3.- Cima.");
                Console.WriteLine("4.- Salir.");
                Console.WriteLine("Digite su opción:");
                Boton = Convert.ToInt32(Console.ReadLine());

                switch (Boton)
                {
                    case 0:
                        Mostrar(ref Pila);
                        break;

                    case 1:
                        Apilar(ref Pila);
                        break;
                    case 2:
                        Desapilar(ref Pila);
                        break;
                    case 3:
                        Cima(ref Pila);
                        break;
                    case 4:
                        break;
                }
            } while (Boton != 5);
            Console.ReadKey();

        }
        public static void Apilar(ref Stack<int> pila)
        {
            Console.WriteLine("Ingrese elemento:"); 
            int num = Convert.ToInt32(Console.ReadLine());
            pila.Push(num);

        }
        public static void Mostrar (ref Stack<int> pila)
        {
            Console.WriteLine("Mostar cuantos elementos hay en la Pila:" + pila.Count);
        }
        public static void Desapilar(ref Stack<int> pila)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());

            pila.Clear();
            Console.WriteLine("La Pila a sido vaciada:");
        }
        public static void Cima(ref Stack<int> pila)
        {

            int num = 0;


            Console.WriteLine("EL último valor de la pila es:");
            Console.WriteLine(num = (int)pila.Pop());

        }
    }
}
            
            
      
            
            

            
       

