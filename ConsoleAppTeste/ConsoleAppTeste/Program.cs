using System;
using System.Collections.Generic;

namespace ConsoleAppTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num1, num2, num3;
            //double media;

            //Console.WriteLine("Digite 3 números para calcular a média:");
            //Console.Write("Número 1: ");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Número 2: ");
            //num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("Número 3: ");
            //num3 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();

            //media = (num1 + num2 + num3) / 3;
            //Console.WriteLine(" Sua média é : {0}", Math.Round(media, 2));

            //if (media < 6.0)
            //{
            //    Console.WriteLine("Você foi reprovado.");
            //}
            //if (media > 6.0)
            //{
            //    Console.WriteLine("Você foi aprovado.");
            //}
            //Console.ReadLine();

            //int i;
            //Console.WriteLine("Funcao FOR:");
            //for (i=1;i<11;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Funcao WHILE:");
            //int j = 1;
            //while(j<11)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Funcao DO/WHILE:");
            //int k = 1;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            //while (k < 11);
            //Console.WriteLine();
            //Console.ReadLine();

            //double[] value = {0.5, 1.6};

            //int i;
            //for(i=0;i<value.Length;i++)
            //{
            //    Console.WriteLine(value[i]);
            //}
            //Console.ReadLine();

            //double[] inputvalue = new double[5];

            //int j;
            //for(j=0;j<inputvalue.Length;j++)
            //{
            //    Console.Write("Digite um numero: ");
            //    inputvalue[j] = Convert.ToDouble(Console.ReadLine());
            //}

            //j = 0;
            //for(j=0;j<inputvalue.Length;j++)
            //{
            //    Console.WriteLine("Número do vetor na posição {0}: {1}", j, Math.Round(inputvalue[j], 1));
            //}
            //Console.ReadLine();

            //string nomeidade;
            //string[] splitnomeidade;
            //for(int i = 0; i<5;i++)
            //{
            //    Console.Write(" Digite o seu nome e idade: ");
            //    nomeidade = Console.ReadLine();
            //    splitnomeidade = nomeidade.Split(" ");

            //    Console.WriteLine("Nome = {0} , Idade = {1}", splitnomeidade[0], splitnomeidade[1]);
            //}
            //Console.ReadLine();

            //string[,] matriz = new string[2,4];
            //int i, j;

            //for (i = 0; i < 2; i++)
            //{
            //    j = 0;
            //    Console.Write("Insere uma matéria: ");
            //    matriz[i, j] = Console.ReadLine(); 
            //    for (j = 1; j < 4; j++)
            //    {
            //        Console.Write("Insere uma media: ");
            //        matriz[i, j] = Console.ReadLine();
            //    }
            //}

            //for (i = 0; i < 2; i++)
            //{
            //    j = 0;
            //    Console.Write("matéria: {0}   ", matriz[i, j]);
            //    Console.Write("media: ");
            //    for (j = 1; j < 4; j++)
            //    {
            //        if (j != 3)
            //        {
            //            Console.Write("{0}   ", matriz[i, j]);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0}", matriz[i, j]);

            //        }
            //    }
            //}
            //Console.ReadLine();

            //int num;
            //Console.Write("Digite um número: ");
            //num = Int32.Parse(Console.ReadLine());
            //int mod = num % 2;
            //if (mod == 0)
            //{
            //    Console.WriteLine("O número digitado é um número par");
            //}
            //if (mod == 1)
            //{
            //    Console.WriteLine("O número digitado é um número ímpar");
            //}
            //Console.ReadLine();

            //int num;
            //Console.Write("Digite um número: ");
            //num = Int32.Parse(Console.ReadLine());
            //string result = VerifyParImpar(num);
            //Console.WriteLine(result);
            //Console.ReadLine();

            Console.Write("Digite um número para a contagem do Fibonacci: ");
            int counter = Int32.Parse(Console.ReadLine());
            fibonacciCounter(counter);
        }

        public static void fibonacciCounter(int pCounter)
        {
            Console.WriteLine("0");
            int i, j = 0, k = 1;
            int nextnum;
            for (i = 0; i < pCounter; i++)
            {
                nextnum = j;
                j = k;
                k = nextnum + k;
                Console.WriteLine(k);
            }
            Console.WriteLine();
            Console.WriteLine("A operação de Fibonacci foi executada {0} vezes.", pCounter);
            Console.ReadLine();
        }

        //public static string VerifyParImpar(int num)
        //{
        //    if(num == 0)
        //    {
        //        return "O número digitado é nulo.";
        //    }
        //    if(num%2 == 0)
        //    {
        //        return "O número digitado é um número par.";
        //    }
        //    else
        //    {
        //        return "O número digitado é um número ímpar.";
        //    }
        //}
    }
}
