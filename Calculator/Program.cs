using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamando a função
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Selecione um opção: ");
            
            short resultado = short.Parse(Console.ReadLine());
            
            switch (resultado)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma()
        {
            //Limpa o console toda vez que rodar o codigo
            Console.Clear();

            //input
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            //input
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            //Espaço de uma linha
            Console.WriteLine("");

            //somando e inserindo o resultado na variavel
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            //Limpa o console toda vez que rodar o codigo
            Console.Clear();

            //input
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            //input    
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            //Espaço de uma linha
            Console.WriteLine("");

            //subtraindo e inserindo o resultado na variavel
            float resultado = v1 - v2;
            Console.WriteLine($"O Resultado da Subtação é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            //Limpa o console toda vez que rodar o codigo
            Console.Clear();

            //input
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            //input
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            //Espaço de uma linha
            Console.WriteLine("");

            //dividindo e inserindo o resultado na variavel
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            //Limpa o console toda vez que rodar o codigo
            Console.Clear();

            //input
            Console.WriteLine("Primeiro Valor:");
            float v1 = float.Parse(Console.ReadLine());

            //input    
            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            //Espaço de uma linha
            Console.WriteLine("");

            //multiplicando e inserindo o resultado na variavel
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }

    }
}