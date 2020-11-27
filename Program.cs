using System;

namespace _27_11_giovanni
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool [] promocao = new bool [2] ;
            int contador = 0;
            string resposta;
            string[] produto = new string [2];
            float[] preco = new float [2];

            Console.WriteLine("-------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Gerenciador de Produtos.");
            Console.ResetColor();
            Console.WriteLine("-------------------------");

            do
            {   
                Console.WriteLine("Menu");
                Console.WriteLine("Selecione uma das seguintes opções:");
                Console.WriteLine("[1] Cadastrar produtos");
                Console.WriteLine("[2] Listar produtos");
                Console.WriteLine("[0] Sair");
                escolha = int.Parse(Console.ReadLine());

            switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro dos produtos");
                        do
                        {
                            if(contador < 2 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º produto");
                            produto[contador] = Console.ReadLine();

                            Console.WriteLine($"Digite o preço do {contador+1} produto");
                            preco [contador] = float.Parse(Console.ReadLine());

                            Console.WriteLine($"Este produto está na promoção ? true/false ");
                            promocao [contador] = bool.Parse(Console.ReadLine());

                            contador++;

                            }else
                            {
                                Console.WriteLine("Limite de produtos excedido");
                                break;
                            }

                            Console.WriteLine("Gostaria de Cadastrar mais produtos ? S/N");
                            resposta = Console.ReadLine();

                        }while (resposta.ToUpper() == "S");

                        break;

                    case 2:
                        Console.WriteLine("Listar os produtos.");
                        for (var i = 0; i < produto.Length; i++)
                        {
                            Console.WriteLine($"produto: {produto[i]}");
                            Console.WriteLine($"preço : {preco[i]}");
                            Console.WriteLine($"promoção : {promocao [i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("obrigado pela visita !");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                

            } 
   
            } while (escolha != 0);
        }

    }
}