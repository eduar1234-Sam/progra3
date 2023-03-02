using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{
    class PruebaVector
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("Metodo de insercion directa");
            Console.Write("Cuantos longitud del vector:");
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

        public void InsercionDirecta()
        {
            int auxili;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                auxili = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > auxili)
                {
                    vector[j + 1] = vector[j];
                    j--;
                }
                vector[j + 1] = auxili;
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
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.InsercionDirecta();
            pv.Imprimir();
        }
    }
}