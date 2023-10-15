using System.ComponentModel;

using desafio1.Models;

namespace desafio1.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public bool Achou(Veiculo veiculo)
        {
            return veiculos.Contains(veiculo);
        }

        public decimal CalcularValorAPagar(int horas)
        {
            return (precoInicial + precoPorHora * horas);
        }

        public void Adicionar(Veiculo veiculo)
        {
            if (Achou(veiculo))
            {
                Console.WriteLine($"O veículo {veiculo.Placa} já encontra-se dentro do estacionamento.");
            }
            else
            {
                Console.WriteLine($"O veículo {veiculo.Placa} adicionado no estacionamento.");
                veiculos.Add(veiculo);
            }
        }

        public bool Remover(string placa)
        {
            bool removeu = false;
            Veiculo veiculo = veiculos.Find(veiculo => veiculo.Placa == placa);
            if (Achou(veiculo))
            {
                veiculos.Remove(veiculo);
                removeu = true;
            }
            return removeu;
        }

        public void Imprimir(string placa, int horas)
        {
            decimal valorTotal = CalcularValorAPagar(horas);
            Console.WriteLine($"O veículo {placa} foi removido e o preço do estacionamento é de R$ {valorTotal}.");
        }

        public void Listar()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (Veiculo veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
