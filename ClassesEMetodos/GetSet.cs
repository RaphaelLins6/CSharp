using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class GetSet
    {

        private class Carro{
            private string Modelo;
            private string Marca;
            private int Ano;
            private int Motor;

            // Construtor padrão
            public Carro() {
                Modelo = "Desconhecido";
                Marca = "Desconhecida";
                Ano = 0;
                Motor = 0;
            }

            public Carro(string modelo, string marca, int ano, int motor){
                Modelo = modelo;
                Marca = marca;
                Ano = ano;
                Motor = motor;
            }

            public string GetModelo(){
                return Modelo;
            }
            public void SetModelo(string modelo){
                Modelo = modelo;
            }
            public string GetMarca(){
                return Marca;
            }
            public void SetMarca(string marca){
                Marca = marca;
            }
            public int GetAno(){
                return Ano;
            }
            public void SetAno(int ano){
                Ano = ano;
            }
            public int GetMotor(){
                return Motor;
            }
            public void SetMotor(int motor){
                Motor = motor;
            }
        }
        public static void Executar(){
            Carro carro = new Carro("Fusca", "Volkswagen", 1970, 1300);
            Console.WriteLine($"Modelo: {carro.GetModelo()}");
            Console.WriteLine($"Marca: {carro.GetMarca()}");
            Console.WriteLine($"Ano: {carro.GetAno()}");
            Console.WriteLine($"Motor: {carro.GetMotor()}");

            Console.WriteLine("Alterando os valores do carro...");
            carro.SetModelo("Civic");
            carro.SetMarca("Honda");
            carro.SetAno(2020);
            carro.SetMotor(2000);

            Console.WriteLine($"Modelo: {carro.GetModelo()}");
            Console.WriteLine($"Marca: {carro.GetMarca()}");
            Console.WriteLine($"Ano: {carro.GetAno()}");
            Console.WriteLine($"Motor: {carro.GetMotor()}");

            Carro carro2 = new Carro();
            carro2.SetModelo("Aventador");
            carro2.SetMarca("Lamborghini");
            carro2.SetAno(2021);
            carro2.SetMotor(5000);
            Console.WriteLine("Criando um novo carro...");
            Console.WriteLine($"Modelo: {carro2.GetModelo()}");
            Console.WriteLine($"Marca: {carro2.GetMarca()}");
            Console.WriteLine($"Ano: {carro2.GetAno()}");
            Console.WriteLine($"Motor: {carro2.GetMotor()}");

            Console.WriteLine("Pressione Enter para continuar...");
            Console.ReadLine();
        }
    }
}