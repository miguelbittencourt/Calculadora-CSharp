﻿using System;

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
            Console.WriteLine("--Calculadora--");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma opção da calculadora: ");
            short opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default:
                    {
                        Console.WriteLine("Opção Inválida!");
                        Menu();
                        break;
                    }
            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = n1 - n2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = n1 / n2;
            Console.WriteLine($"O resultado da divisao é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            float resultado = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
