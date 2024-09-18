using System;

namespace SistemaBiblioteca
{

    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Programação em .NET", "2023");
            Revista revista = new Revista("OESTE", "2024");
            Dvd dvd = new Dvd("Interstellar", "2014");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nBiblioteca Tech Class");
                Console.WriteLine("1. Alugar Livro");
                Console.WriteLine("2. Alugar Revista");
                Console.WriteLine("3. Alugar DVD");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Devolver Revista");
                Console.WriteLine("6. Devolver DVD");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        livro.Alugar();
                        break;
                    case "2":
                        revista.Alugar();
                        break;
                    case "3":
                        dvd.Alugar();
                        break;
                    case "4":
                        Console.Write("Informe os dias que atrasou: ");
                        int atrasoLivro = int.Parse(Console.ReadLine());
                        livro.Devolver(atrasoLivro);
                        break;
                    case "5":
                        Console.Write("Informe os dias que atrasou: ");
                        int atrasoRevista = int.Parse(Console.ReadLine());
                        revista.Devolver(atrasoRevista);
                        break;
                    case "6":
                        Console.Write("Informe os dias que atrasou: ");
                        int atrasoDvd = int.Parse(Console.ReadLine());
                        dvd.Devolver(atrasoDvd);
                        break;
                    case "7":
                        Console.WriteLine("Saindo");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
