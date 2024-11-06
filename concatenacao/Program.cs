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

//Cast/Casting (Conversão de um número do tipo string para int, float ou double usando Convert)
string valorEmTexto = "100";
Console.WriteLine("Valor da variável string:" + valorEmTexto);
Console.WriteLine("A váriavel valorTexto é do tipo: " + valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("Após conversão a variável numeroConvertido é do tipo: " + numeroConvertido.GetType());

//Converter qualquer tipo para string com ToString()
int numero2 = 123;
Console.WriteLine(numero2.GetType());

string numeroComoString = numero2.ToString();
Console.WriteLine(numeroComoString.GetType());

// Personalização de Formatação para data e hora
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataHoraFormatada = dataAtual.ToString("HH:mm:ss");
Console.WriteLine(dataHoraFormatada);

//Uso 3 
double preco = 29.99;
Console.WriteLine($"o preco e: {preco.ToString("C2")}");

//Uso 4 
decimal valor = 1234.56m;
string valorUS = valor.ToString("c", new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("c", new System.Globalization.CultureInfo("pt-br"));
Console.WriteLine(valorBR);