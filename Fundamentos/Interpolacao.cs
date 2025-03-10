using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar() {
            // Interpolação de strings com o símbolo '$'
            // A interpolação de strings permite inserir valores de variáveis diretamente em uma string.
            // O símbolo '$' é usado para indicar que uma string é interpolada.

            string nome = "Maria";
            int idade = 30;
            double altura = 1.65;

            // Interpolação de strings simples
            string mensagem = $"Olá, meu nome é {nome} e eu tenho {idade} anos.";
            Console.WriteLine(mensagem);

            // Interpolação de strings com formatação
            // A formatação permite controlar a forma como os valores são exibidos.
            // A formatação é feita usando dois pontos ':' seguidos do formato desejado.

            string mensagemFormatada = $"Minha altura é {altura:F2} metros."; // F2 exibe o número com 2 casas decimais
            Console.WriteLine(mensagemFormatada);

            // Interpolação de strings com expressões
            // A interpolação de strings também permite inserir expressões diretamente na string.

            int dobroDaIdade = idade * 2;
            string mensagemComExpressao = $"O dobro da minha idade é {dobroDaIdade}.";
            Console.WriteLine(mensagemComExpressao);

            // Interpolação de strings com alinhamento
            // O alinhamento permite controlar o espaço ocupado pelos valores na string.
            // O alinhamento é feito usando vírgula ',' seguida do número de espaços desejado.

            string mensagemAlinhada = $"Nome: {nome,-10} Idade: {idade,5}"; // -10 alinha o nome à esquerda em 10 espaços, 5 alinha a idade à direita em 5 espaços
            Console.WriteLine(mensagemAlinhada);

            // Interpolação de strings com caracteres de escape
            // Caracteres de escape permitem inserir caracteres especiais em uma string.
            // O caractere de escape é a barra invertida '\'.

            string mensagemComEscape = $"Eu gosto de \"C#\"."; // \" insere aspas duplas na string
            Console.WriteLine(mensagemComEscape);

            // Interpolação de strings com strings literais textuais
            // Strings literais textuais permitem inserir caracteres de escape sem usar a barra invertida.
            // A string literal textual é indicada pelo símbolo '@' antes das aspas.

            string caminho = @"C:\Arquivos\Documentos"; // A barra invertida não precisa ser escapada
            Console.WriteLine(caminho);
        }
    }
}
