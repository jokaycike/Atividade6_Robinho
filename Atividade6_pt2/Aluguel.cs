using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_pt2
{
    public class Aluguel 
    {
        public void InformacoesAluguel()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Alugar Carro");
                Console.WriteLine("2 - Alugar Moto");
                Console.WriteLine("3 - Alugar Caminhao");
                Console.WriteLine("0 - Sair");


                int op1 = int.Parse(Console.ReadLine());
                
                switch (op1)
                {
                    case 1:
                        Console.WriteLine("Qual a marca do carro?");
                        string marca = Console.ReadLine();
                        Console.WriteLine("Qual o modelo do carro?");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("Qual a Placa do carro?");
                        string placa = Console.ReadLine();
                        Console.WriteLine("De qual ano você quer o carro?");
                        int ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o preço diário aproximado que você quer para o carro?");
                        float precoDiaria = float.Parse(Console.ReadLine());
                        Console.WriteLine("Quantas portas você quer que o carro tenha?");
                        int _numeroPortas = int.Parse(Console.ReadLine());

                        Carro carro = new Carro(marca, modelo, placa, ano, precoDiaria, _numeroPortas);

                        Console.WriteLine("Seu Carro tem as seguintes caracteristica:");
                        Console.WriteLine("Marca:");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.Marca);
                        Console.ResetColor();
                        Console.WriteLine("Modelo");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.Modelo);
                        Console.ResetColor();
                        Console.WriteLine("Placa");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.Placa);
                        Console.ResetColor();
                        Console.WriteLine("Ano");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.Ano);
                        Console.ResetColor();
                        Console.WriteLine("PrecoDiaria");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.PrecoDiaria.ToString("C"));
                        Console.ResetColor();
                        Console.WriteLine("Nº de portas");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(carro.NumeroPortas);
                        Console.ResetColor();
                        Console.WriteLine("Pressione qulquer tecla para continuar...");
                        Console.ReadKey();
                        break;


                    case 2:
                        Console.WriteLine("Qual a marca da moto?");
                        string Motomarca = Console.ReadLine();
                        Console.WriteLine("Qual o modelo da moto?");
                        string Motomodelo = Console.ReadLine();
                        Console.WriteLine("Qual a Placa da moto?");
                        string Motoplaca = Console.ReadLine();
                        Console.WriteLine("De qual ano você quer a moto?");
                        int Motoano = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o preço diário aproximado que você quer para a moto?");
                        float MotoprecoDiaria = float.Parse(Console.ReadLine());
                        Console.WriteLine("Quantas cilindradas você quer que a moto tenha?");
                        int _cilindradas = int.Parse(Console.ReadLine());

                        Moto moto = new Moto(Motomarca, Motomodelo, Motoplaca, Motoano, MotoprecoDiaria, _cilindradas);

                        Console.WriteLine("Sua Moto tem as seguintes caracteristica:");
                        Console.WriteLine("Marca:");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.Marca);
                        Console.ResetColor();
                        Console.WriteLine("Modelo");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.Modelo);
                        Console.ResetColor();
                        Console.WriteLine("Placa");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.Placa);
                        Console.ResetColor();
                        Console.WriteLine("Ano");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.Ano);
                        Console.ResetColor();
                        Console.WriteLine("PrecoDiaria");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.PrecoDiaria.ToString("C"));
                        Console.ResetColor();
                        Console.WriteLine("Nº de cilidradas");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(moto.cilindradas);
                        Console.ResetColor();
                        Console.WriteLine("Pressione qulquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Qual a marca do caminhão?");
                        string Caminhaomarca = Console.ReadLine();
                        Console.WriteLine("Qual o modelo do caminhão?");
                        string Caminhaomodelo = Console.ReadLine();
                        Console.WriteLine("Qual a Placa do caminhão?");
                        string Caminhaoplaca = Console.ReadLine();
                        Console.WriteLine("De qual ano você quer o caminhão?");
                        int Caminhaoano = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o preço diário aproximado que você quer para o caminhão?");
                        float CaminhaoprecoDiaria = float.Parse(Console.ReadLine());
                        Console.WriteLine("Qual a capacidade de carga você quer que o caminhão tenha?");
                        int _capacidadeCarga = int.Parse(Console.ReadLine());

                        Caminhao caminhao = new Caminhao(Caminhaomarca, Caminhaomodelo, Caminhaoplaca, Caminhaoano, CaminhaoprecoDiaria, _capacidadeCarga);

                        Console.WriteLine("Seu Caminhao o tem as seguintes caracteristica:");
                        Console.WriteLine("Marca:");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.Marca);
                        Console.ResetColor();
                        Console.WriteLine("Modelo");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.Modelo);
                        Console.ResetColor();
                        Console.WriteLine("Placa");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.Placa);
                        Console.ResetColor();
                        Console.WriteLine("Ano");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.Ano);
                        Console.ResetColor();
                        Console.WriteLine("PrecoDiaria");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.PrecoDiaria.ToString("C"));
                        Console.ResetColor();
                        Console.WriteLine("Capacidade de carga");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(caminhao.CapacidadeCarga);
                        Console.ResetColor();
                        Console.WriteLine("Pressione qulquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.WriteLine("Saindo do sistema de aluguel...");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
