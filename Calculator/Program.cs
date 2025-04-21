using System;
using System.Numerics;
using System.Security.Cryptography;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Porcentagem");
            Console.WriteLine("7 - Sair");

            Console.WriteLine(" -------------------------------");

            Console.WriteLine("Selecione um opção: ");

            short res = short.Parse(Console.ReadLine());

            switch(res) 
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 6: Porcentagem(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {            
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da Subtação é: {resultado}.");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Potencia()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O resultado da Potência é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        
        static void Porcentagem()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = (v2 * v1) / 100;
            Console.WriteLine($"O resultado da porcentagem é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
