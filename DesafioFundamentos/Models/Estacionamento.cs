namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> listaVeiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public bool PlacaExiste(string placa)
        {
            return listaVeiculos.Contains(placa);
        }

        public void AdicionarVeiculo()
        {
            string placa;
            do
            {
                Console.Write("Digite a placa do veículo: ");
                placa = Console.ReadLine();

                if (PlacaExiste(placa))
                {
                    Console.WriteLine("Erro: Já existe um veículo cadastrado com essa placa. Tente novamente.");
                }
            } while (PlacaExiste(placa));

            listaVeiculos.Add(placa);
            Console.WriteLine("Veículo cadastrado com sucesso.");
        }

        public void RemoverVeiculo()
        {
            if (listaVeiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados para remover.");
                return;
            }

            string placaRemover;
            do
            {
                Console.Write("Digite a placa do veículo para remover: ");
                placaRemover = Console.ReadLine();

                if (!PlacaExiste(placaRemover))
                {
                    Console.WriteLine("Veículo não encontrado. Tente novamente.");
                }
            } while (!PlacaExiste(placaRemover));

            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            int horasPermanencia;
            while (!int.TryParse(Console.ReadLine(), out horasPermanencia) || horasPermanencia < 1)
            {
                Console.WriteLine("Digite um valor válido para as horas (mínimo 1):");
            }

            listaVeiculos.Remove(placaRemover);

            decimal valorTotal = precoInicial;
            if (horasPermanencia > 1)
                valorTotal += (horasPermanencia - 1) * precoPorHora;

            Console.WriteLine($"Veículo removido. Valor total: R${valorTotal:0.00}");
        }

        public void ListarVeiculos()
        {
            if (listaVeiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
            }
            else
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in listaVeiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
    }
}