using System;
using System.Collections;
using System.Collections.Generic;

namespace NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 = I // 5 = V // 10 = X // 50 = L // 100 = c // 500 = D // 1000 = M

            Console.WriteLine("Digite Um Numero !");

            int Numero = int.Parse(Console.ReadLine());

            int[] Romanos = new int[] { 1000, 500,400, 100,90, 50,40, 10, 9, 5, 4, 1 };

            int[] Quantidades = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            string[] letras = new string[] { "M", "D","CD", "C","XC", "L","XL", "X", "IX", "V","IV","I" };

            for (int i = 0; i < Romanos.Length; i++)
            {
                Quantidades[i] = Numero / Romanos[i];

                Numero = Numero % Romanos[i];                

                Retorno(letras[i], Quantidades[i]);

            }

            Console.ReadLine();
        }
        public static void Retorno(string letra,int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(letra);
            }
        }
    }
}
