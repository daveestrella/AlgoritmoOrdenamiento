using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int[] ordenado;
            int i;

            Console.Write("Cuantos datos desea ingresar?: ");
            arr = new int[Int32.Parse(Console.ReadLine())];

            Console.WriteLine("Ingrese los datos");
            for(i=0;i<arr.Length;i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            ordenado = Ordenar(arr);
            //Imprimir(ordenado);

            Console.ReadKey();

        }

        public static void Imprimir(int[] arr, int li, int ls)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                if (i >= li && i <= ls)
                    Console.ForegroundColor = ConsoleColor.Cyan;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] Ordenar(int[] arr)
        {
            int li = 0;
            int ls = arr.Length - 1;
            int mayor, menor, indice;
            int i,aux;

            Imprimir(arr, li,ls);
            do
            {
                mayor = int.MinValue;
                menor = int.MaxValue;
                indice = -1;                             

                for (i = li; i <= ls; i++)
                {
                    if (arr[i] > mayor)
                    {
                        mayor = arr[i];
                        indice = i;
                    }
                    
                    
                }

                aux = arr[indice];
                arr[indice] = arr[ls];
                arr[ls] = aux;
                ls--;
                
                Imprimir(arr, li, ls);
                

                for (i = li; i <= ls; i++)
                {
                    if (menor > arr[i])
                    {
                        menor = arr[i];
                        indice = i;
                    }
                }

                aux = arr[indice];
                arr[indice] = arr[li];
                arr[li] = aux;
                li++;

                
                Imprimir(arr, li, ls);
                
            } while (li != ls);

            return arr;
        }
    }
}
