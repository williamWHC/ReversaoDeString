using System;
using System.Threading;

namespace TesteNeon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um programa que receba uma palavra que faza o mesmo sentido ao inverte de traz para frente
            //a sua palavra ex: "arara" - "avo" - "osso" e confirme se as duas palavras são iguais.
            Menu();
            // string txt = "arara";
            // Console.WriteLine(txt.Length);
            //teste
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Olá, Boa Tarde!");
            Console.WriteLine("Programa para invertes palavras.");
            Console.WriteLine("Vamo começar ?");
            Thread.Sleep(1000);
            Console.WriteLine("Opção - 0 (Sair)");
            Thread.Sleep(1000);
            Console.WriteLine("Opção - 1 (Começar)");
            Thread.Sleep(1000);
            short number = short.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: SearchWord(); break;
                default: Menu(); break;
            }
        }

        static void SearchWord()
        {
            Console.Clear();
            Console.WriteLine("OLÁ\nBEM VINDO AO PROGRAMA DE INVERSÃO DE PALAVRA");
            Thread.Sleep(1000);
            Console.Write("Digite uma palavra:");
            string word = Console.ReadLine();
            string newWord = "";

            if (word == "" || word == " ") { SearchWord(); }

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord += word[i].ToString();
            }

            Console.WriteLine($"Entrada: {word}");
            Console.WriteLine($"Inverção: {newWord}");
            Thread.Sleep(1000);

            Console.WriteLine("Gostaria de verificar se a palavra é identica?");
            Console.WriteLine("Opção 0 (Sair)");
            Console.WriteLine("Opção 1 (Verificar)");
            Console.Write("Opção: ");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: CheckData(word, newWord); break;
                default: Menu(); break;
            }
        }

        static void CheckData(string word, string newword)
        {
            Console.WriteLine($"Palavras identica = {word == newword}");
            Console.ReadLine();
            Menu();
        }
    }
}

