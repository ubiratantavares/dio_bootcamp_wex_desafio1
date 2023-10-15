using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio1.Models
{
    public class Leitura
    {

        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }

        public string LerMarca()
        {
            Console.WriteLine("Digite a marca do veículo: ");
            string Marca = Console.ReadLine();
            return Marca ?? "desconhecida"!;
        }

        public string LerModelo()
        {
            Console.WriteLine("Digite o modelo do veículo: ");
            string Modelo = Console.ReadLine();
            return Modelo ?? "desconhecido";
        }

        public string LerPlaca()
        {
            Console.WriteLine("Digite a placa do veículo: ");
            string Placa = Console.ReadLine();
            return Placa ?? "não identificada";
        }

        public int LerTotalDeHorasEstacionado()
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                if (int.TryParse(input, out int horas))
                {
                    return horas;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido.");
                    return LerTotalDeHorasEstacionado(); // Recursivamente pede uma entrada válida.
                }
            }
        }
    }
}