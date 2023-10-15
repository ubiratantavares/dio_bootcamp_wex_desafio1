using desafio1.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento\n");
Console.WriteLine("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n");
Console.WriteLine("Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

string marca;
string modelo;
string placa;

Leitura leitura = new Leitura();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar\n");
    Console.WriteLine("Digite a sua opção:");
    switch (Console.ReadLine())
    {
        case "1":
            marca = leitura.LerMarca();
            modelo = leitura.LerModelo();
            placa = leitura.LerPlaca();
            Veiculo veiculo = new Veiculo(marca, modelo, placa);
            estacionamento.Adicionar(veiculo);
            break;
        case "2":
            placa = leitura.LerPlaca();
            if (estacionamento.Remover(placa))
            {
                int horas = leitura.LerTotalDeHorasEstacionado();
                estacionamento.Imprimir(placa, horas);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.\nConfira se digitou a placa corretamente.");
            }
            break;
        case "3":
            estacionamento.Listar();
            break;
        case "4":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    if (exibirMenu)
    {
        Console.WriteLine("Pressione uma tecla para continuar.");
        Console.ReadLine();
    }
}
Console.WriteLine("O programa se encerrou.");
