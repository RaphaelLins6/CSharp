using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Props
    {
        // Propriedades com validação
        // As propriedades com validação são usadas para garantir que os valores atribuídos a elas atendam a certos critérios.
        // No exemplo abaixo, a propriedade Preco tem uma validação que impede que um preço negativo seja atribuído.
        // Isso é feito usando um bloco set que verifica se o valor é menor que zero e lança uma exceção se for o caso.
        // As propriedades com validação são úteis para garantir a integridade dos dados e evitar erros no código.
        public class Computador{
            double preco;
            public double Preco{
                get { return preco; }
                set {
                    if (value < 0){
                        throw new ArgumentException("O preço não pode ser negativo!");
                    }
                    preco = value;
                }
            }

            // somente leitura
            // Propriedades somente leitura são usadas para garantir que uma propriedade não possa ser alterada após a inicialização.
            // No exemplo abaixo, a propriedade PrecoDesconto é somente leitura e só pode ser definida no construtor.
            // Isso é útil para garantir que o valor de uma propriedade não seja alterado acidentalmente em outras partes do código.
            public double PrecoDesconto { 
            get => Preco * 0.9; // 10% de desconto
            // O operador => é usado para definir uma expressão lambda que calcula o preço com desconto.
            }

            // Construtor com parâmetros
            // O construtor com parâmetros é chamado quando um objeto é criado e valores específicos são passados para ele.
            // Ele é útil para inicializar propriedades com valores fornecidos pelo usuário ou por outra parte do código.
            // No exemplo abaixo, o construtor com parâmetros inicializa o preço do computador com um valor fornecido pelo usuário.
            // O construtor com parâmetros é definido com o mesmo nome da classe e tem parâmetros que podem ser usados para inicializar propriedades.
            // Ele pode ser usado para inicializar propriedades ou executar código de configuração.
            public Computador(string cpu, string ram, string placaMae, string placaVideo, string armazenamento, string fonte, string gabinete)
            {
                Cpu = cpu;
                Ram = ram;
                PlacaMae = placaMae;
                PlacaVideo = placaVideo;
                Armazenamento = armazenamento;
                Fonte = fonte;
                Gabinete = gabinete;
            }

            // Construtor padrão
            // O construtor padrão é chamado quando um objeto é criado sem passar parâmetros.
            // Ele é útil para inicializar valores padrão ou executar código de configuração.
            // No exemplo abaixo, o construtor padrão inicializa o preço do computador para 2000 e imprime uma mensagem.
            // O construtor padrão é chamado automaticamente quando um objeto é criado.
            // O construtor padrão não tem parâmetros e é definido com o mesmo nome da classe.
            // Ele pode ser usado para inicializar propriedades ou executar código de configuração.
            public Computador()
            {
                Cpu = string.Empty;
                Ram = string.Empty;
                PlacaMae = string.Empty;
                PlacaVideo = string.Empty;
                Armazenamento = string.Empty;
                Fonte = string.Empty;
                Gabinete = string.Empty;
            }

            // Propriedades autoimplementadas
            public string Cpu { get; set; }
            public string Ram { get; set; }
            public string PlacaMae { get; set; }
            public string PlacaVideo { get; set; }
            public string Armazenamento { get; set; }
            public string Fonte { get; set; }
            public string Gabinete { get; set; }
        }

        public static void Executar()
        {
            // Criando um objeto da classe Computador usando o construtor sem parâmetros
            Computador computador = new Computador();
            computador.Preco = 2000;
            Console.WriteLine($"O preço do computador é: {computador.Preco}");
            // computador.Preco = -100; // Isso vai gerar uma exceção
            // Console.WriteLine($"O preço do computador é: {computador.Preco}");
            computador.Cpu = "Intel Core i7";
            computador.Ram = "16GB";
            computador.PlacaMae = "Asus ROG Strix B550-F";
            computador.PlacaVideo = "NVIDIA GeForce RTX 3060";
            computador.Armazenamento = "1TB SSD";
            computador.Fonte = "Corsair 650W";
            computador.Gabinete = "Cooler Master MasterBox Q300L";
            Console.WriteLine($"CPU: {computador.Cpu}");
            Console.WriteLine($"RAM: {computador.Ram}");
            Console.WriteLine($"Placa Mãe: {computador.PlacaMae}");
            Console.WriteLine($"Placa de Vídeo: {computador.PlacaVideo}");
            Console.WriteLine($"Armazenamento: {computador.Armazenamento}");
            Console.WriteLine($"Fonte: {computador.Fonte}");
            Console.WriteLine($"Gabinete: {computador.Gabinete}");
            Console.WriteLine($"Preço com desconto: {computador.PrecoDesconto}");
            // O preço com desconto é calculado automaticamente usando a propriedade PrecoDesconto.
            // Isso demonstra como as propriedades podem ser usadas para encapsular lógica e fornecer acesso a dados de forma controlada.
            
            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}