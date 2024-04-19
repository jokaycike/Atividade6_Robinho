using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_pt2
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, string placa, int ano, float precodiario, int _numeroPortas) : base(marca, modelo, placa, ano, precodiario)
        {
            Console.WriteLine("Quantas portas você quer que o carro tenha??");
            NumeroPortas = _numeroPortas;
        }
        public void MostrarNumeroDePortas()
        {
            Console.WriteLine($"Número de Portas: {NumeroPortas}");
        }

    }
}
