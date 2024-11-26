using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Carro:Veiculo
    {
        private bool automatico {get; set;}
        private int numeroDePortas{get; set; }


        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas) : base(marca, modelo, ano, velocidadeAtual)
        {
            this.automatico = automatico;
            this.numeroDePortas = numeroDePortas;
        }
    
    
        public void AbrirPortas()
        {   
            Console.WriteLine("As portas do carro estão abertas.");
        } 
    }
}