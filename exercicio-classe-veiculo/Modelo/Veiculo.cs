using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classes.Modelo
{
    public class Veiculo
    {
        // Atributos
        string marca;
        string modelo;
        int ano;
        double peso;
        
        // Construtor
        public Veiculo(string marca, string modelo, int ano, double peso) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.peso = peso;
        }

        // Métodos Andar e Falar
        public void Acelerar()
        {
            Console.WriteLine($"{modelo} está acelerando.");
        }
        public void Frear()
        {
            Console.WriteLine($"{modelo} está freando.");
        }
    }
}