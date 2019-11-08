using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilayCola03
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1- Pila.");
                Console.WriteLine("2- Cola.");
                Console.WriteLine("3- Reutilización.");
                Console.WriteLine("4- Salir. ");
                Console.WriteLine("Opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Stack<int> pila = new Stack<int>();
                    int boton = 0;
                    do
                    {
                        boton = Menu();
                        switch (boton)
                        {
                            case 1:
                                Apilar(ref pila);
                                break;
                            case 2:
                                Mostrar(ref pila);
                                break;
                            case 3:
                                Desapilar(ref pila);
                                break;
                            case 4:
                                Cima(ref pila);
                                break;
                            case 5:

                                break;
                        }
                    } while (opcion != 5);

                    Console.WriteLine("El programa finalizó.");

                    public static void Apilar(ref Stack<int> lapila)
                    {
                        Console.WriteLine("Ingrese elemento:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        lapila.Push(num);

                    }
                    public static void Mostrar(ref Stack<int> lapila)
                    {
                        Console.WriteLine("Mostar cuantos elementos hay en la Pila:" + lapila.Count);
                    }
                    public static void Desapilar(ref Stack<int> lapila)
                    {
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        lapila.Clear();
                        Console.WriteLine("La Pila a sido vaciada:");
                    }
                    public static void Cima(ref Stack<int> lapila)
                    {

                        int num = 0;


                        Console.WriteLine("EL último valor de la pila es:");
                        Console.WriteLine(num = (int)lapila.Pop());

                    }


                    public static int Menu()
                    {
                        Console.WriteLine(" Stack Menu");
                        Console.WriteLine(" 1.- Apilar. ");
                        Console.WriteLine(" 2.- Mostar cuantos elementos hay en la Pila.");
                        Console.WriteLine(" 3.- Desapilar. ");
                        Console.WriteLine(" 4.- Cima ");
                        Console.WriteLine(" 5.- Salir. ");
                        Console.WriteLine("Nueva opcion:");
                        try
                        {
                            int numeros = Convert.ToInt32(Console.ReadLine());
                            return numeros;
                        }
                        catch
                        {
                            return 0;
                        }
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar:");
                    Console.ReadKey();
  
                Console.WriteLine("Desea seguir usando la pila?");
                Console.WriteLine("1.- Si");
                Console.WriteLine("2.- No");
                Console.WriteLine("Digite su opcion");
                int opcion2 = Convert.ToInt32(Console.ReadLine());
                if (opcion2 == 1)
                {
                    Menu();
                }
                else
                {
                    Console.Clear();
                }
            
                if (opcion == 2)
                {
                    Queue<int> cola = new Queue<int>();
                    int clave = 0;
                    do
                    {
                        clave = Menu();
                        switch (clave)
                        {
                            case 1:
                                Añadir(ref cola);
                                break;
                            case 2:
                                Eliminar(ref cola);
                                break;
                            case 3:
                                MostrarCola(cola);
                                break;
                            case 4:
                                break;

                        }

                    } while (opcion != 4);

                    Console.WriteLine("El programa finalizó.");

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
                    public static int Menu1()
                    {
                        Console.WriteLine(" Stack Menu");
                        Console.WriteLine(" 1.- Añadir. ");
                        Console.WriteLine(" 2.- Eliminar. ");
                        Console.WriteLine(" 3.- Mostrar cuantos elementos hay en la Cola.");
                        Console.WriteLine(" 4.- Salir. ");
                        Console.WriteLine("Ingresar opcion: ");

                        try
                        {
                            int numero2 = Convert.ToInt32(Console.ReadLine());
                            return numero2;
                        }
                        catch
                        {
                            return 0;
                        }
                    }


                    public static void MostrarCola(Queue<int> lacola)
                    {

                        Console.WriteLine("Hay" + lacola.Count + "elemento en la cola.");
                        Console.ReadKey();
                    }

                        Console.ReadLine();
                    }
                    Console.WriteLine("Desea seguir usando la cola?");
                    Console.WriteLine("1.- Si");
                    Console.WriteLine("2.- No");
                    Console.WriteLine("Digite su opcion");
                    int opcion3 = Convert.ToInt32(Console.ReadLine());
                    if (opcion3 == 1)
                    {
                        Menu();
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
                    if (opcion == 3)
                    {
                    }
                    if (opcion == 4)
                    {
                        Console.ReadKey();
                        numero = 1;
                    }
                } while (numero == 0) ;
                Console.ReadLine();
            }
            
    }
    
}
    
