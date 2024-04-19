using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    public class Imprimir
    {
        Documento _documento = new Documento();

        public void Solicitartexto()
        {
            Console.WriteLine("Digite o que vc quer imprimir:");
            _documento.texto = Console.ReadLine();
        }
        public void EnviarImpressao(){
            Impressora _impressora = new Impressora(_documento);
            _impressora.qtdeCopia = 1;
            _impressora.Imprimir();
        }
    }
}
