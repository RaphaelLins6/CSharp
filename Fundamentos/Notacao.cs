using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Notacao
    {
        public static void Executar() {
            // Notação ponto para acessar membros de um objeto
            // A notação ponto é usada para acessar membros (propriedades e métodos) de um objeto.

            // Criando um objeto da classe 'Pessoa'
            Pessoa pessoa = new Pessoa();

            // Acessando propriedades do objeto 'pessoa' usando notação ponto
            pessoa.Nome = "Maria";
            pessoa.Idade = 30;

            // Chamando métodos do objeto 'pessoa' usando notação ponto
            pessoa.Apresentar();

            // Notação ponto para acessar membros estáticos de uma classe
            // A notação ponto também é usada para acessar membros estáticos de uma classe.

            // Acessando a propriedade estática 'PI' da classe 'Math'
            double pi = Math.PI;
            Console.WriteLine("Valor de PI: " + pi);

            // Chamando o método estático 'Sqrt' da classe 'Math'
            double raizQuadrada = Math.Sqrt(25);
            Console.WriteLine("Raiz quadrada de 25: " + raizQuadrada);

            // Notação ponto com tipos primitivos
            // Tipos primitivos também possuem métodos que podem ser acessados usando notação ponto.

            string texto = "Olá, mundo!";

            // Chamando o método 'ToUpper' da string 'texto'
            string textoMaiusculo = texto.ToUpper();
            Console.WriteLine("Texto em maiúsculo: " + textoMaiusculo);

            // Chamando o método 'Length' da string 'texto'
            int comprimento = texto.Length;
            Console.WriteLine("Comprimento do texto: " + comprimento);
        }
    }

    // Classe 'Pessoa' para demonstrar notação ponto com objetos
    public class Pessoa {
        // Propriedades da classe 'Pessoa'
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Método da classe 'Pessoa'
        public void Apresentar() {
            Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
        } 
    }
}
