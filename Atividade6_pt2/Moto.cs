using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6_pt2
{
    public class Moto : Veiculo
    {
        public int cilindradas { get; set; }

        public Moto(string Motomarca, string Motomodelo, string Motoplaca, int Motoano, float Motoprecodiario, int _cilindradas) : base(Motomarca, Motomodelo, Motoplaca, Motoano, Motoprecodiario)
        {
            Console.WriteLine("Quantas cilindradas você quer que a moto tenha??");
            cilindradas = _cilindradas;
            
        }
         public void MostrarCiindradas()
         {
            Console.WriteLine($"Quantidade de cilindradas: {cilindradas}");
        }
    }
}
