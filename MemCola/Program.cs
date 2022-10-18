using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemCola
{
    internal class Program
    {
        static void Main(string[] args)
        { // cola : Estructura FIFO ( primero en entrar, primero en salir
            {
                string cadena;
                Queue colaStr = new Queue();
                Console.WriteLine("Ingrese una cadena en la cola");
                cadena = Console.ReadLine();
                while (cadena != string.Empty)
                {
                    colaStr.Enqueue(cadena);
                    Console.WriteLine("Ingrese próxima cadena en la cola");
                    cadena = Console.ReadLine();
                }
                while (colaStr.Count > 0)
                {
                    Console.WriteLine((string)colaStr.Dequeue());
                }
                Console.ReadKey();
            }
        }


    }
    }
