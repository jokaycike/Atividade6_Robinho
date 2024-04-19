using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    public class Impressora
    {
        public int qtdeCopia;
        Documento _docImprimir;

        public Impressora(Documento _documento)
        {
            _docImprimir = _documento;
        } 

        public void Imprimir()
        {
            for(int i = 0; i < qtdeCopia; i++)
            {
                Console.WriteLine(_docImprimir.texto);
            }
        }
    }
}
