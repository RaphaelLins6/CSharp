using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Pontos
    {
        public int pontos;
        public Pontos(int Pontos){
            this.pontos = Pontos;
        }
        public Pontos(){}
    }
    public class LanceLivre : Pontos {
        
    }

    public class PontoDois : Pontos {
       
    }

    public class PontoTres : Pontos {
        
    }

    public class TotalPontos {
        public int Pontos;

        //public void Arremessar(LanceLivre lance) {
        //    Pontos += lance.pontos;
        //}
        //public void Arremessar(PontoDois ponto) {
        //    Pontos += ponto.pontos;
        //}
        //public void Arremessar(PontoTres ponto) {
        //    Pontos += ponto.pontos;
        //} 

        public void Arremessar(Pontos pontos) {
           Pontos += pontos.pontos;
        }
    }
    class Polimorfismo
    {
        public static void Executar()
        {
            // Polimorfismo é a capacidade de um objeto assumir várias formas.
            // Isso é feito através da herança e interfaces.

            LanceLivre lance = new LanceLivre();
            lance.pontos = 1;
            PontoDois pontoDois = new PontoDois();
            pontoDois.pontos = 2;
            PontoTres pontoTres = new PontoTres();
            pontoTres.pontos = 3;

            TotalPontos totalPontos = new TotalPontos();
            totalPontos.Arremessar(lance);
            totalPontos.Arremessar(pontoDois);
            totalPontos.Arremessar(pontoTres);
            totalPontos.Arremessar(lance);
            totalPontos.Arremessar(lance);
            totalPontos.Arremessar(pontoTres);
            totalPontos.Arremessar(lance);
            totalPontos.Arremessar(lance);
            Console.WriteLine($"Total de pontos: {totalPontos.Pontos}");
            // O polimorfismo permite que o mesmo método seja chamado em diferentes classes,

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}