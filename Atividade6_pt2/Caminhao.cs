using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_pt2
{
    public class Caminhao : Veiculo
    {
        public float CapacidadeCarga { get; set; }

        public Caminhao(string Caminhaomarca, string Caminhaomodelo, string Caminhaoplaca, int Caminhaoano, float Caminhaoprecodiario, int _capacidadeCarga) : base(Caminhaomarca, Caminhaomodelo, Caminhaoplaca, Caminhaoano, Caminhaoprecodiario)
        {
            Console.WriteLine("Qual a capacidade de carga vc quer que seu caminhão tenha??");
            CapacidadeCarga = _capacidadeCarga;
        }
        public void MostrarCarga()
        {
            Console.WriteLine($"Quantidade de cilindradas: {CapacidadeCarga}");
        }
    }
}
