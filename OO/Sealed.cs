using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    // Selaed é um modificador de classe que impede que a classe seja herdada.
    // Isso é útil quando você quer garantir que a implementação de uma classe não seja alterada por subclasses.
    sealed class ValorUnico{
        public double Valor { get; set; }
        public ValorUnico(double valor){
            Valor = valor;
        }
    }

    /*  class ValorAlterado : ValorUnico{
            public double ValorAlterado { get; set; }

            public ValorAlterado(double valor, double valorAlterado) : base(valor){
                ValorAlterado = valorAlterado;
            }
        }
    */
    // A classe ValorUnico é selada, portanto não pode ser herdada.
    public class Sealed
    {
        public static void Executar(){
            
            ValorUnico valor = new ValorUnico(23.6);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Valor Unico: ");
            Console.WriteLine(valor.Valor);

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}