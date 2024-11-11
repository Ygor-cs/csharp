// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

/* Operadores Aritmeticos 
adição +
subtrção - 
multiplicação *
divisão /

mod % busca na divisão o seu resto!
exponenciação ** eleva um valor à potencia de outro 
incremento ++ aumenta o valor da variavel ou numero em 1 
decremento -- diminui o valor da variavel ou em numero 1 

3 school
*/

Console.WriteLine("Wello World!");
double resultado1 = 12 + 8 + 12 / 3; 
Console.WriteLine(resultado1);

double resultado2 = (12 + 8 + 12) / 3; 
Console.WriteLine(resultado2);

double resultado3 = (2 + 8) * 2 / 4; 
Console.WriteLine(resultado3);

/* Operadores de comparação
igual ==
diferente !=
maior ou igual >=
menor ou igual <=
*/

/* Operadores lógicos 
utilizados para expressões booleanas 

operadores em c# 
AND Lógico && (E)
 só retorna true apenas se ambas forem verdadeiras - true 

OR Lógico || (OU)
 retorna true se pelo menos umas das duas expressões forem verdadeiras - true 

NOT Lógico ! (NÃO)
 inverte o valor logico da expressão, se valor é verdadeiro se torna falso e vice-versa

XOR Lógico ^(OU Exclusivo)
 retorna true somente se uma das expressões for true e a outra for false  
*/ 

//AND Logico 
 bool a = true;
 bool b = false;
 Console.WriteLine(a && b);

//OR Logico
 bool a1 = true;
 bool b1 = false;
 Console.WriteLine(a1 || b1); 

//NOT Logico
 bool a2 = true;
 Console.WriteLine(!a2);

//XOR Logico ^ (OU Exclusivo)
 bool a3 = true;
 bool b3 = false;
 Console.WriteLine(a3^b3);

 bool a4 = true;
 bool b4 = false; 
 bool c = false; 
 bool resultado = !a4 || (b4 && c);
 Console.WriteLine(resultado);

bool a5 = false; 
bool b5 = false; 
bool c1 = false; 
bool resultado4 = !a5 || b5 && c1;
Console.WriteLine(resultado4);


