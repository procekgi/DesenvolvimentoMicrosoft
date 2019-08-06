using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercicio");
            Console.WriteLine("1 - Exercicio 01");
            Console.WriteLine("2 - Exercicio 02");
            Console.WriteLine("3 - Exercicio 03");
            Console.WriteLine("4 - Exercicio 04");
            Console.WriteLine("5 - Exercicio 05");
            Console.WriteLine("6 - Exercicio 06");
            Console.WriteLine("7 - Exercicio 07");
            Console.WriteLine("8 - Exercicio 08");
            Console.WriteLine("9 - Exercicio 09");
            Console.WriteLine("10 - Exercicio 10");
            int exercicio = Convert.ToInt16(Console.ReadLine());

            if (exercicio == 1)
            {
                CalculaArea();
            }
            else if (exercicio == 2)
            {
                ConverteMoney();
            }

            Console.WriteLine("\nAperte uma tecla para continuar...");
            Console.ReadKey();
        }

        public static void CalculaArea()
        {
            Console.WriteLine("\n Digite a altura do retangulo \n");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Digite a largura do retangulo \n");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O resultado da área deste retangulo é " + altura * largura);

        }

        public static void ConverteMoney()
        {
            Console.WriteLine("Digite um valor em R$: \n");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor em dólares é " + valor/3.78);
            Console.WriteLine("O valor em euros é " + valor/4.21);
            Console.WriteLine("O valor em peso argentino é " + valor/0.08);

        }

        public static void MaiorEMenor()
        {
            
        }

    }
}
