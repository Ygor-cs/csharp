// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Tipos de dados primitivos 
// Numeros inteiros  
short ano = 2025;
int contador = 10;
long populacaoMundial = 7800000000;

// Numeros de ponto flutuante 
float temperatura = 43.6f;
double precoProduto = 199.90; 

// Caracter
char inical = "w";

// Tipos Logicos 
bool estaLogado = true;
bool ativo = false; 

// Tipos de dados não primitivos 
string saudacao = "Ola mundo!";

//Arrays
int[] Numeros = {1, 2, 3, 4, 5};
string[] nomes = {"Ygor", "Ana Clara", "Mariangela"};

// Classes
public class Pessoa 
{
    public string Nome;
    public int idade;   
}

// Structs  
public class Ponto 
{
    public int X;
    public int Y;   
}

// Enums 
public enum diaDaSemana 
{
    Segunda, Terça, Quarta, Quinta, Sexta, Sabado, Domingo
}

// Interfaces 
public interface IVeiculo 
{
    void Mover();
}

// Delegates 
public void delegate Processar(int Numero);

// Nullable types 
int? idade = null; 