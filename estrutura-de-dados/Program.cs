// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Estruturas de Dados 
//Exemplo 01: Vetor (Array)
// int[] meuArray = new int[5];
// meuArray[0] = 10;
// meuArray[1] = 20;
// meuArray[2] = 30;
// meuArray[3] = 40;
// meuArray[4] = 50;
// Console.WriteLine("Números no array: ");
// for (int i = 0; i < meuArray.Length; i++)
// {
//     Console.WriteLine(meuArray[i]); 
// }

// // Exemplo 02: Lista (List)
List<string> listaDeNomes = new List<string> {"Ygor", "Ana Clara", "Morgana"};
listaDeNomes.Add("Ratinho");
//Exibindo a lista inicial
Console.WriteLine("Nome na lista:");
for(int i = 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
//Verificar se um nome está na lista 
Console.WriteLine("\nVerficação da existência do nome Mariangela: ");
string nomeParaVerificar = "Mariangela";
if (listaDeNomes.Contains(nomeParaVerificar))
{
    Console.WriteLine($"{nomeParaVerificar} está na lista.");
}
else
{
    Console.WriteLine($"{nomeParaVerificar} não está na lista.");
}
//Remover um nome da lista 
Console.WriteLine("\nApós remover Ygor:");
string nomeParaRemover = "Ygor";
bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
if (foiRemovido)
{
    Console.WriteLine($"{nomeParaRemover} foi removido da lista.");
}
else 
{
    Console.WriteLine($"{nomeParaRemover} não foi encontrado na lista.");
}
//Exibindo a lista final após a remoção
Console.WriteLine("\nNomes na lista após a remoção: ");
for (int i = 0; i < listaDeNomes.Count; i++)
{
    Console.WriteLine(listaDeNomes[i]);
}
