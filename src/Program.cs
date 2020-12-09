using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do exercício proposto de matrizes da seção 6");
            Console.WriteLine("Entre com os dados dos funcionários");

            Console.Write(Environment.NewLine + "Digite as dimensões da matriz (linhas colunas): ");
            string[] matDimensoes = Console.ReadLine().Split(' ');
            int m = int.Parse(matDimensoes[0]);
            int n = int.Parse(matDimensoes[1]);

            Console.WriteLine($"Matriz de dimensões {m}x{n}");
            int[,] matriz = new int[m, n];

            Console.Write(Environment.NewLine + "\t");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = i + j;
                    Console.Write($"\t{matriz[i, j]}");
                }
                Console.Write(Environment.NewLine);
                if (i == (m / 2) - 1)
                    Console.Write($"Matriz[{m}x{n}] = ");
                else
                {
                    if (i < m - 1)
                        Console.Write("\t");
                }

            }

            Console.Write("Digite um número para ser mapeado na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine(Environment.NewLine + $"Matriz[{i}x{j}] = {matriz[i, j]}");
                        if (i > 0)
                            Console.WriteLine($"\tAcima: Matriz[{i - 1}x{j}] = {matriz[i - 1, j]}");
                        if (i + 1 < matriz.GetLength(0))
                            Console.WriteLine($"\tAbaixo: Matriz[{i + 1}x{j}] = {matriz[i + 1, j]}");
                        if (j > 0)
                            Console.WriteLine($"\tEsquerda: Matriz[{i}x{j - 1}] = {matriz[i, j - 1]}");
                        if (j + 1 < matriz.GetLength(1))
                            Console.WriteLine($"\tDireita: Matriz[{i}x{j + 1}] = {matriz[i, j + 1]}");
                    }
                }



        }
    }
}
