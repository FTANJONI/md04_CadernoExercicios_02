using System;

namespace md04_CadernoExercicios_02
{
    class Program
    /*
     2. Crie um programa que peça 10 números inteiros e apresente: a média, o maior e o
    menor.
     */
    {
        static void Main(string[] args)
        {
            double media;//, maior, menor;
            int soma, maior = 0, menor = -1, total = 0, i = 0;
            do
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número:");
                soma = Convert.ToInt32(Console.ReadLine());
                if (menor < 0)
                {
                    menor = soma;
                }
                if (soma > maior)
                {
                    maior = soma;
                }
                else if (soma < menor)
                {
                    menor = soma;
                }
                total = total + soma;
                i++;
            } while (i < 10);
            media = Convert.ToDouble(total) / Convert.ToDouble(i);
            Console.WriteLine("\nMédia= {0}", media.ToString("0,0"));
            Console.WriteLine("\nMaior número digitado = {0} ",  maior.ToString("0,0"));
            Console.WriteLine("\nMenor número digitado = {0} ", menor.ToString("0,0"));
        }
    }
}
