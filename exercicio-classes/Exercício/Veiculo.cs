using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Veiculo
    {
        // Atributos encapsulados com modificadores de acesso private, protected, getters e setters 
        private string marca { get; set; } 
        private string modelo { get; set; } 
        private int ano { get; set; }     
        protected double velocidadeAtual { get; set; } 

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.velocidadeAtual = velocidadeAtual; 
        }

        // Método concreto Acelerar
        public void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }

        // Método concreto Frear
        public void Frear(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h");
        }
    }
}