namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.Clear();
            string placa = "";
            Console.WriteLine("Digite a placa do veículo: ");
            placa = Console.ReadLine();
            if (placa == null || placa == "")
            {
                Console.WriteLine("Digite a placa do veículo!");
            }
            else
            {
                veiculos.Add(placa.ToUpper());
                Console.Clear();
                Console.WriteLine("Veiculo cadastrado com sucesso!");
                Console.WriteLine("\nPressione uma tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any())
            {
                string placa = "";
                Console.Clear();
                Console.WriteLine("Digite a placa do veículo para remover:\n");
                placa = Console.ReadLine();

                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.Clear();
                    Console.WriteLine("Tempo que o veículo permaneceu estacionado:\n");
                    int tempoEstacionado = Convert.ToInt32(Console.ReadLine());
                    if (tempoEstacionado > 0)
                    {
                        veiculos.Remove(placa.ToUpper());
                        Console.Clear();

                        Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de {precoPorHora * tempoEstacionado + precoInicial}");
                        Console.WriteLine("\nAperte uma tecla para continuar:");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há nenhum veículo estacionado no esctacionamento!");
                Console.WriteLine("\nAperte uma tecla para continuar:");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Veículos estacionados:\n");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($" - {veiculos[i]}");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
            Console.WriteLine("\nPressione uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}