class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha um exemplo para visualizar:");
            Console.WriteLine("1. Vetor");
            Console.WriteLine("2. Matriz");
            Console.WriteLine("3. Cubo");
            Console.WriteLine("4. Sair");
            Console.Write("Opção: ");

            try
            {
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ShowArrayExample();
                        Pause();
                        break;
                    case 2:
                        ShowMatrixExample();
                        Pause();
                        break;
                    case 3:
                        ShowCubeExample();
                        Pause();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                        Pause();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                Pause();
            }
        }
    }

    static void ShowArrayExample()
    {
        Console.Clear();
        int[] vetor = new int[5] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Exemplo de Vetor:");
        Console.WriteLine("Índice\tValor");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"{i}\t{vetor[i]}");
        }
    }

    static void ShowMatrixExample()
    {
        Console.Clear();
        int[,] matriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("Exemplo de Matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void ShowCubeExample()
    {
        Console.Clear();
        int[,,] cubo = new int[2, 2, 2]
        {
                { { 1, 2 }, { 3, 4 } },
                { { 5, 6 }, { 7, 8 } }
        };

        Console.WriteLine("Exemplo de Cubo:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Matriz {i + 1}:");
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(cubo[i, j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    static void Pause()
    {
        Console.WriteLine("\nPressione Enter para continuar.");
        Console.ReadLine();
    }
}
