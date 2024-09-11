using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Decimal precoInicial = 0, precoPorHora = 0;

Console.Clear();
Console.WriteLine("Seja bem-vindo ao sistema!\n");

Console.WriteLine("Digite o preço de entrada: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

Console.WriteLine("\nDigite o preço por hora: ");
precoPorHora = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite uma opção:\n\n" +
    "1 - Cadastrar veículo\n" +
    "2 - Remover veículo\n" +
    "3 - Listar veículos\n" +
    "4 - Encerrar sessão\n");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("O programa se encerrou!");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
