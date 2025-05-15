using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    public class PrimeiraExecao
    {
        public class Conta
        {
            double Saldo;

            public Conta(double saldoInicial)
            {
                Saldo = saldoInicial;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo insuficiente");
                }
                Saldo -= valor;
            }
        }
        public static void Executar()
        {
            var conta = new Conta(100);

            Console.WriteLine("-------------------------------------------------");
            
            try
            {
                conta.Sacar(200);
                Console.WriteLine("Saque realizado com sucesso");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exceção tratada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execução finalizada");
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}