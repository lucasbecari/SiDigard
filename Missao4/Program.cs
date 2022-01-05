using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variavel que armazena um número inteiro
            int inteiro = 10;
            Console.WriteLine($"valor da variável é: {inteiro}");
            Console.WriteLine("O valor da variável é: " + inteiro);
            Console.WriteLine();

            // Variavel que armazena um número long
            long longo = 16320;
            Console.WriteLine($"valor da variável é: {longo}");
            Console.WriteLine("O valor da variável é: " + longo);
            Console.WriteLine();

            // Variável que armazena double
            double deci = 5.50;
            Console.WriteLine($"valor da variável é: {deci}");
            Console.WriteLine("O valor da variável é: " + deci);
            Console.WriteLine();

            //Variavel que armazena string
            string nome = "Becari";
            Console.WriteLine($"valor da variável é: {nome}");
            Console.WriteLine("O valor da variável é: " + nome);
            Console.WriteLine();

            //Variavel que armazena verdadeiro ou falso
            bool trueorfake = true;
            Console.WriteLine($"valor da variável é: {trueorfake}");
            Console.WriteLine("O valor da variável é: " + trueorfake);
            Console.WriteLine();


            List<string> carros = new List<string>();
            carros.Add("Uno");
            carros.Add("Gol");
            carros.Add("Palio");

            foreach (var carro in carros)
            {
                Console.WriteLine($"O valor da variável da lista de strings é: {carro}");
            }


            Console.ReadLine();




        }
    }
}
