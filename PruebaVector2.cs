using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector2
{
    class PruebaVector2
    {
        private int[] vector;

        public void Cargar()
        {
            Console.WriteLine("Metodo de Shell Sort");
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

        public void Shell()
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] > vector[(e - 1) + salto])
                        {
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
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
            PruebaVector2 pv = new PruebaVector2();
            pv.Cargar();
            pv.Shell();
            pv.Imprimir();
        }
    }
}