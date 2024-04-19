using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_pt2
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public float PrecoDiaria { get; set; }

        public Veiculo(string marca, string modelo, string placa, int ano, float precodiario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Ano = ano;
            PrecoDiaria = precodiario;
        }

        public string Mostrar()
        {
            return $"Veículo: {Marca} {Modelo}, Ano: {Ano}, Preço da Diária: R$ {PrecoDiaria}";
        }
    }
}
