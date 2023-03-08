using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Burbuja
{
    class Burbuja
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("1 Metodo de Burbuja");
            Console.Write("Cuantos longitud del vector: ");
            string linea;
            linea = Console.ReadLine();
            int cant;
            cant = int.Parse(linea);
            vector = new int[cant];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento "+(f+1)+": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void MetodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f]+"  ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Burbuja pv = new Burbuja();
            pv.Cargar();
            pv.MetodoBurbuja();
            pv.Imprimir();
        }
    }
}