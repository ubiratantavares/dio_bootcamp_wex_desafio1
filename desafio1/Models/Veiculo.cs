using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio1.Models
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public Veiculo(string marca, string modelo, string placa)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Placa = placa;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Placa: {Placa}";
        }
    }
}