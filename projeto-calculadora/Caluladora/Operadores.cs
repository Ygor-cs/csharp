using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto-calculadora.calculadora 
{
    public class Calculadora
    {
        double somar;
        double subtrair;
        double dividir;
        double multiplicar;

        public Calculadora(double somar, double subtrair, double dividir, double multiplicar)
        {
            this.somar = somar;
            this.subtrair = subtrair;
            this.dividir = dividir;
            this.multiplicar = multiplicar;
        }
        public void EscolherUmaOperacao()
        {
            Console.WriteLine("Escolha uma operação entre +, -, *, /: ")
            string? escolherOperacao = Console.Readline();
        }
        public void EscolhaOPrimeiroNumero()
        {
            Console.WriteLine("Escolha o primeiro número: ");
            int? a = Console.Readline();
        }
        public void EscolhaOSegundoNumero()
        {
            Console.WriteLine("Escolha o segundo número: ");
            int? b = Console.Readline();
        }
        public void RealizarOperacaoDeSomar(double a, double b)
        {
            return a + b;
        }
        public void RealizarOperacaoDeSubtrair(double a, double b)
        {
            return a - b;
        }
        public void RealizarOperacaoDeMultiplicar(double a, double b)
        {
            return a * b;
        }
        public void RealizarOperacaoDeDividir(double a, double b)
        { 
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não permitida.");
                return a / b;
            }
        }
    }
}