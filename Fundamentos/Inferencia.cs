using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar() {
            // Inferência de tipo com a palavra-chave 'var'
            // A palavra-chave 'var' permite que o compilador infira o tipo de uma variável com base no valor atribuído a ela.

            // Inferência de tipo para um número inteiro
            var idade = 30; // O compilador infere que 'idade' é do tipo 'int'

            // Inferência de tipo para um número de ponto flutuante
            var altura = 1.75; // O compilador infere que 'altura' é do tipo 'double'

            // Inferência de tipo para uma string
            var nome = "João"; // O compilador infere que 'nome' é do tipo 'string'

            // Inferência de tipo para um valor booleano
            var ehEstudante = true; // O compilador infere que 'ehEstudante' é do tipo 'bool'

            // Exibição dos tipos inferidos
            Console.WriteLine("Tipo de 'idade': " + idade.GetType().ToString());
            Console.WriteLine("Tipo de 'altura': " + altura.GetType().ToString());
            Console.WriteLine("Tipo de 'nome': " + nome.GetType().ToString());
            Console.WriteLine("Tipo de 'ehEstudante': " + ehEstudante.GetType().ToString());

            // Inferência de tipo em um loop 'foreach'
            int[] numeros = { 1, 2, 3, 4, 5 };

            foreach (var numero in numeros) {
                Console.WriteLine("Número: " + numero); // O compilador infere que 'numero' é do tipo 'int'
            }

            // Inferência de tipo com tipos anônimos
            var pessoa = new { Nome = "Maria", Idade = 25 }; // O compilador infere um tipo anônimo com propriedades 'Nome' e 'Idade'

            Console.WriteLine("Nome da pessoa: " + pessoa.Nome);
            Console.WriteLine("Idade da pessoa: " + pessoa.Idade);

            // Limitações da inferência de tipo
            // A inferência de tipo só pode ser usada para variáveis locais dentro de métodos.
            // A inferência de tipo requer que a variável seja inicializada no momento da declaração.
            // A inferência de tipo não pode ser usada para campos de classe ou parâmetros de método.
        }
    }
}
