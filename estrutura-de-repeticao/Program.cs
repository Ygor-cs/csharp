﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Estrutura de repeticao (Loop)
While
Do While 
For
Foreach
*/
/*
Random numeroAleatorio = new Random();
int numero = numeroAleatorio.Next(1, 101);
int contador = 0;
Console.WriteLine($"Número Alvo: {contador}");
// Loop que incrementa o contador até ele atingir o número alvo
while ( contador <= numero )
{
    Console.WriteLine($"Contador: {contador}.");
    contador ++;
}
Console.WriteLine($"Contador atingiu o número alvo: {contador}");
*/
/* Esrtrutura de repetição Do While
int numero = 0;
do
{
    Console.WriteLine($"Número: {numero}");
    numero++;
} while (numero < 10);
*/

/* Estrutura de repetição For
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}
*/

/*Estrutra de  repetição ForEach
string[] nomes = {"Ygor", "Ana Clara", "Morgana"};
foreach (string nome in nomes)
{
    Console.WriteLine(nome);    
}
*/
/* EXERCÍCIO 1
  Crie um algoritmo que some todos os números pares de 1 a 100 e exiba o resultado no console

/*   EXERCÍCIO 2 
   Crie um algoritmo q faça uma contagem regressiva de 10 a 1 e exiba "Decolar!" ao final 

/*   EXERCÍCIO 3
   Crie um algoritmo que conte o número de vogais (a, e, i, o, u) na palavra e exiba o resultado

/*   EXERCÍCIO 4
   Crie um algoritmo que solicite uma palavra ou frase do usuário, verifique se é um palíndromo, ou seja, se é igual da trás para frente. eemplo: ana, radar, etc.

/*   EXERCÍCIO 5 
   Crie um algoritmo onde o computador escolhe um número aleatório entre 1 e 100, e o usuário deve advinhar. Após cada tentativa, o programa indica se o número é maior ou menor
*/
// //1
// int soma = 0;
// for(int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         soma = soma +i;
//     }
// }
// Console.WriteLine($"Valor é: {soma}."); 

// //2
// int numero = 10;
// do
// {
//     Console.WriteLine($"Número: {numero}");
//     numero--;
// } while (numero >= 1);
// Console.WriteLine("Decolar!");

// //3
// Console.WriteLine("Digite uma palavra:");
// string? palavra = Console.ReadLine().ToLower(); //Colocar mais uma palavra
// int vogal = 0;
// foreach (char letra in palavra)
// {
//   if ("aeiou".Contains(letra))
//   {
//     vogal++;
//   }
// }
// Console.WriteLine(vogal);
        
// //.reverse e .toarray 
// //4
// Console.WriteLine("Digete uma palavra ou uma frase:");
// string? entrada = Console.ReadLine().ToLower();
// string reverso = new string(entrada.reverse().ToArray());
// if(entrada == reverso)
// {
//   Console.WriteLine("É um palíndromo");
// }
// else 
// {
//   Console.WriteLine("Não é um palíndromo");
// }
//5
Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
int palpite;
int contador = 0;
bool acertou = false;
Console.WriteLine("Tentativa de acertar o número entre 1 e 100:");
while (!acertou)
{
  Console.WriteLine("Digite seu palpite: ");
  palpite = int.Parse(Console.ReadLine());

  if (palpite < numeroAleatorio)
  {
    Console.WriteLine("O número é maior!");
    contador++;
  }
  else if (palpite > numeroAleatorio)  
  {
    Console.WriteLine("O número é menor!");
    contador++;
  }
  else 
  {
    contador++; 
    Console.WriteLine($"Parabéns! Você adivinhou o número sorteado '{numeroAleatorio}' depois de {contador} tentativas.");
    acertou = true;
  }
}  