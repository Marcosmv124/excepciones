using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionIndexOutOfRange
{
    class Program
    {
       
    
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            Random R = new Random();

           
            try
            {
                for (int X = 0; X < arreglo.Length; X++)
                {
                    arreglo[X] = R.Next(10, 99);
                   
                }
                Array.Sort(arreglo);
                Console.WriteLine("\nLista Arreglada: "); 
                for (int X = 0; X < arreglo.Length; X++)
                {
                  
                    Console.WriteLine("\t{0}.-{1}", X + 1, arreglo[X]);
                }
                Console.Write("\nPresione enter Para continuar..");
                Console.ReadKey();
                arreglo[15] = 12345;
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("\n\nMensaje del error: " + i.Message);
                Console.WriteLine("\nRuta del error: " + i.StackTrace);
                Console.Write("\nPresione enter para continuar"); 
            }
            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("Presione enter para salir del programa : ");
                Console.ReadKey(); 
            }
        }

        
    }
}
