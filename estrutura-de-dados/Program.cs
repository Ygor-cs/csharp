// // See https://aka.ms/new-console-template for more information
// //Console.WriteLine("Hello, World!");
// //Estruturas de Dados 
// //Exemplo 01: Vetor (Array)
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

// // // Exemplo 02: Lista (List)
// List<string> listaDeNomes = new List<string> {"Ygor", "Ana Clara", "Morgana"};
// listaDeNomes.Add("Ratinho");
// //Exibindo a lista inicial
// Console.WriteLine("Nome na lista:");
// for(int i = 0; i < listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }
// //Verificar se um nome está na lista 
// Console.WriteLine("\nVerficação da existência do nome Mariangela: ");
// string nomeParaVerificar = "Mariangela";
// if (listaDeNomes.Contains(nomeParaVerificar))
// {
//     Console.WriteLine($"{nomeParaVerificar} está na lista.");
// }
// else
// {
//     Console.WriteLine($"{nomeParaVerificar} não está na lista.");
// }
// //Remover um nome da lista 
// Console.WriteLine("\nApós remover Ygor:");
// string nomeParaRemover = "Ygor";
// bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
// if (foiRemovido)
// {
//     Console.WriteLine($"{nomeParaRemover} foi removido da lista.");
// }
// else 
// {
//     Console.WriteLine($"{nomeParaRemover} não foi encontrado na lista.");
// }
// //Exibindo a lista final após a remoção
// Console.WriteLine("\nNomes na lista após a remoção: ");
// for (int i = 0; i < listaDeNomes.Count; i++)
// {
//     Console.WriteLine(listaDeNomes[i]);
// }

// Conjunto (Set)
// HashSet<int> conjunto = new HashSet<int> {1, 2, 3 };
// conjunto.Add(4);
// conjunto.Add(2);

// Console.WriteLine("Elementos do conjunto");
// foreach(int elemento in conjunto)
// {
//     Console.WriteLine(elemento);
// }
// HashSet<string> frutas = new HashSet<string> {"Maçã", "Banana", "Laranja"};
// frutas.Add("Uva");
// frutas.Add("Maçã");

// Console.WriteLine("Frutas no conjunto:");
// foreach (string fruta in frutas)
// {   
//     Console.WriteLine(fruta);
// }

// Console.WriteLine("\nVerficação de existência:");
// Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não está no conjunto");

// frutas.Remove("Laranja");
// Console.WriteLine("\nApós remover Laranja");
// foreach (string fruta in frutas)
// {   
//     Console.WriteLine(fruta);
// }

// // EXERCÍCIOS = 1
// int soma = 0;
// int[] numeros = {1, 2, 3, 4, 5}; 
// for (int i = 0; i < 5; i++)
// {
//     soma = soma + numeros[i];
// } 
//  Console.WriteLine($"O valor da soma é: {soma}");
 
 /* Resolução do fessô
 int[] numeros = {1, 2, 3, 4, 5};
 int soma = 0;
 foreach (int numero in numeros)
 {
    soma += numero;
 }
*/
// // Exercício 2
// List<string>nomes = new List<string> {"Jeane", "Wanderson", "Jeane", "Ryan", "Jeane", "Jeane"};
// int contador = 0;
// foreach(string nome in nomes)
// {
//     if (nome == "Jeane")
//     {
//         contador++;
//     }
// }
// Console.WriteLine($"Jeane aparece: {contador} vezes na lista");

/* Resolução do fessô
igual a minha
*/

// //Exercício 3
// List<int> numeros = new List<int>{1, 2, 2, 3, 4, 4, 5};
// HashSet<int> conjunto = new HashSet<int> (numeros);
// foreach(int numero in conjunto)
// {
//     Console.WriteLine(numero);
// }

// //Exercício 4
// HashSet<string> frutas = new HashSet<string> {"Maçã", "Banana", "Laranja"};
// Console.WriteLine(frutas.Contains("Banana") ? "Banana está no conjunto" : "Banana não está no conjunto");

// //Exercício 5
// List<int> numeros = new List<int>();
// numeros.Add(1);
// numeros.Add(2);
// numeros.Add(3);
// numeros.Add(4);
// numeros.Add(5);
// foreach(int numero in numeros)
// {
//     Console.WriteLine(numero);
// }