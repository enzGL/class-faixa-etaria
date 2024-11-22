using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faixa_etaria_19_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("=================================\n");
            Console.Write("= Classificação de faixa etária =");
            Console.Write("\n===============================\n");
            Console.ResetColor();

            while (!flag)
            {
                Console.Write("\nDigite a idade(ou 'S' para sair): ");
                String input1 = Console.ReadLine();

                if (input1.ToUpper() == "S")
                {
                    Console.WriteLine("Programa encerrado.");
                    return;
                }

                if (int.TryParse(input1, out int idade) && idade >= 0 && idade <= 120)
                {
                    if (idade < 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Essa pessoa é uma Criança.");
                        Console.ResetColor();
                    }
                    else if (idade <= 17)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Essa pessoa é um Adolescente.");
                        Console.ResetColor();
                    }
                    else if (idade <= 59)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Essa pessoa é um Adulto.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Essa pessoa é um Idoso.");
                        Console.ResetColor();
                    }
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Por favo digite uma idade valida."); 
                }

            }
            Console.ReadKey();
        }
    }
}
