// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Concatenação
 unir duas ou mais strings
*/
string nome = "Ygor";
string saudacao = "Olá, " + nome + "! Bem-vindo.";
Console.WriteLine(saudacao);

/* Interpolação 
incorporar variaveis diretamente em uma string
*/ 
string nome1 = "Ygor";
string saudacao1 = $"Olá, {nome1}! Bem vindo.";
Console.WriteLine(saudacao1);

/* Operador GetType()
 retornapara saber qual é o tipo de variável q estamos usando
*/
int numero = 5;
Console.WriteLine(numero.GetType());

/* Palavra-chave typeof
 usado para obter o tipo de classe ou estrutura 
*/
Console.WriteLine(typeof(int));

/* Metódo Parse 
 fazer converção de uma string que tenha um valor de número 
*/ 
string valorTexto = "100";
Console.WriteLine("A variável valorTexto é do tipo:" + valorTexto.GetType());

int numero1 = int.Parse(valorTexto);
Console.WriteLine(numero1);
Console.WriteLine("A variável numeroParse é do tipo:" + numero1.GetType());

