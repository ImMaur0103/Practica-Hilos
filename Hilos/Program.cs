using System;
using System.Threading;

namespace Hilos
{

    class Program
    {
        static void CambioColor()
        {    
            for (int i = 0; i < 10000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (i%10 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (i % 10 == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (i % 10 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (i % 10 == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (i % 10 == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (i % 10 == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (i % 10 == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (i % 10 == 8)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (i % 10 == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (i % 10 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
            }
        }
        static void Imprimir()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("<Bloqueo de pantalla>");
            }
        }
        
        static void Main(string[] args)
        {
            Thread cont = new Thread(CambioColor);
            Thread impresion = new Thread(Imprimir);
            Console.WriteLine("---------------Programa de Hilos---------------");
            Console.WriteLine("Cambio de colores mientras Imprime\n");
            Console.ReadKey();
            Console.WriteLine("Iniciamos cronometro de 2 minutos");
            cont.Start();
            impresion.Start();
            Console.ReadKey();
        }
    }
}
