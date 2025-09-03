using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Preço fixo conforme solicitado
decimal precoInicial = 7.00m;
decimal precoPorHora = 5.00m;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine($"Preço da primeira hora: R${precoInicial:0.00}");
Console.WriteLine($"Preço das demais horas: R${precoPorHora:0.00} por hora");

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("\nDigite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (exibirMenu)
    {
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}

Console.WriteLine("O programa se encerrou");
