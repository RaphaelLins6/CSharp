using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    // Exceções personalizadas são criadas para representar erros específicos em um aplicativo.
    // Elas herdam de Exception e podem incluir informações adicionais sobre o erro.
    // Exemplo de exceção personalizada:
    public class ExecaoNegativa : Exception
    {
        public ExecaoNegativa() { }

        public ExecaoNegativa(string message) : base(message) { }

        public ExecaoNegativa(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ExecaoImpar : Exception
    {
        public ExecaoImpar(string message) : base(message) { }
    }
    public class ExecoesPersonalizadas
    {
        public static int ParPositivo()
        {
            Random random = new Random();
            int numero = random.Next(-23, 23);

            if (numero < 0)
            {
                throw new ExecaoNegativa("Número negativo gerado: " + numero);
            }
            else if (numero % 2 != 0)
            {
                throw new ExecaoImpar("Número ímpar gerado: " + numero);
            }

            return numero;
        }
        public static void Executar()
        {
            Console.WriteLine("-------------------------------------------------");

            try
            {
                int numero = ParPositivo();
                Console.WriteLine("Número gerado: " + numero);
            }
            catch (ExecaoNegativa ex)
            {
                Console.WriteLine("Exceção Negativa: " + ex.Message);
            }
            catch (ExecaoImpar ex)
            {
                Console.WriteLine("Exceção Ímpar: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}