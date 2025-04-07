using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class ParametrosPorReferencia
    {
        // O parâmetro ref indica que o argumento passado para o método pode ser alterado dentro do método.
        // O ref é usado quando o valor do parâmetro é necessário antes de ser passado para o método.
        // O parâmetro ref deve ser inicializado antes de ser passado para o método.
        public static void AlteraRef(ref int numero){
                numero += 17;
            }

        // O parâmetro out indica que o argumento passado para o método deve ser inicializado dentro do método.
        // O out é usado quando o valor do parâmetro não é necessário antes de ser passado para o método.
        public static void AlterarOut(out int numero){
                numero = 0;
                numero += 23;
            }
        public static void Executar(){
            
            // O parâmetro ref deve ser inicializado antes de ser passado para o método.
            int numero = 6;
            Console.WriteLine($"Valor original: {numero}"); // Saída: 6
            AlteraRef(ref numero);
            Console.WriteLine($"AlteraRef: {numero}"); // Saída: 23

            int numero2;
            AlterarOut(out numero2);
            Console.WriteLine($"AlterarOut: {numero2}"); // Saída: 23
            // O parâmetro out não precisa ser inicializado antes de ser passado para o método.

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}