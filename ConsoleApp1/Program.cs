using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
    Escreva um programa que retorne uma string 
    separadas por vírgulas do número 1 ao N.
    No entanto, para múltiplos de 3 ele deverá escrever X ao invés do número 
    e para múltiplos de 5 ele deverá escrever Y.
    Para números que são múltiplos de 3 e 5 deverá escrever Z.
    Exemplos: 
    Entrada N = 15, 
    Entrada N = 0, Saída = ""
*/



namespace ConsoleApp1
{
    class Program
    {
        //static string f(int N)
        //{
        //    StringBuilder retorno = new StringBuilder();

        //    for (int i = 1; i < N; i++)
        //    {


        //        if (i % 3 == 0 && i % 5 == 0)
        //        {
        //            retorno.Append("Z,");
        //        }


        //        if (i % 3 == 0)
        //        {
        //            retorno.Append("X,");
        //        }


        //        if (i % 5 == 0 )
        //        {
        //            retorno.Append("Y,");
        //        }


        //        retorno.Append($"{i},");


        //    }

        //    return retorno.ToString();

        //   // Saída = "1,2,X,4,Y,X,7,8,X,Y,11,X,13,14,Z"
        //}

        static string f(int N)
        {
            // Saída = "1,2,X,4,Y,X,7,8,X,Y,11,X,13,14,Z"

            var retorno = new StringBuilder();

            for (int i = 1; i < N; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    retorno.Append("Z,");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        retorno.Append("Y,");
                    }
                    else
                    {
                        retorno.Append(i % 3 == 0 ? "X," : $"{i},");
                    }
                }
            }

            return retorno.ToString(); //.Remove(retorno.Length - 1, 1).ToString();
        }

        static void Main(string[] args)
        {

            //MaisBarato();

            //Console.WriteLine("[{0}]", f(15));
            //Console.WriteLine("[{0}]", f(0));
            //Console.WriteLine("[{0}]", f(30));
        }


        static void MaisBarato()
        {
            Produto[] produtos = new Produto[5];

            produtos[0] = new Produto("Lamborghini", 1000000);
            produtos[1] = new Produto("Jipe", 46000);
            produtos[2] = new Produto("Brasília", 16000);
            produtos[3] = new Produto("Smart", 46000);
            produtos[4] = new Produto("Fusca", 17000);

            
            double maisBarato = produtos.First().Preco;

            for (int i = 0; i < produtos.Length; i++)
            {
                if (produtos[i].Preco < maisBarato)
                {
                    maisBarato = produtos[i].Preco;
                }
            }



            Console.WriteLine($"O carro mais barato custa {maisBarato}");
        }

        //static int g(int[] A)
        //{
        //    var dic = new Dictionary<int, int>();

        //    foreach (int key in A)
        //    {
        //        if (dic.ContainsKey(key))
        //            dic[key] = dic[key] + 1;
        //        else
        //            dic.Add(key, 1);
        //    }

        //    int counter = 0;

        //    foreach (var kvp in dic)
        //    {
        //        if (kvp.Value > 1)
        //            counter = counter + 1;
        //    }


        //    return counter;
        //}

        //static void Main()
        //{
        //    Console.WriteLine("[{0}]", g(new int[] { 1, 2, 2, 3, 4, 5, 6, 6 }));
        //    Console.WriteLine("[{0}]", g(new int[] { 1, 1, 1, 4, 3, 4, 6, 5 }));
        //    Console.WriteLine("[{0}]", g(new int[] { 2, 2, 1, 1, 5, 4, 4, 5 }));
        //}
    }

    internal class Produto
    {
        public string NomeCarro;
        public double Preco;

        public Produto(string nomeCarro, double preco)
        {
            this.NomeCarro = nomeCarro;
            this.Preco = preco;
        }
    }
}
