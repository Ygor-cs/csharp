// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*Estrutura de repeticao (Loop)
While
Do While 
For
Foreach
*/
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
