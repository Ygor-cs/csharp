// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int idade1 = 18;
string entrada1 = $"Qual é a sua idade? {idade1}. Entrada permitida";
Console.WriteLine(entrada1);

int idade2 <=18;
string entrada2 = $"Qual é a sua idade? {idade2}.";

bool a = true;
bool b = false;
*/
/*bool ehMaiorIdade = false;
bool possuiAutorizacaoResponsavel = true;
//com if
if (eMaiorIdade || possuiAutorizacaoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada nao liberada");
}
//com operador ternario
bool ehMaiorIdade = false;
bool possuiAutorizacaoResponsavel = true;
string resultado = ehMaiorIdade || possuiAutorizacaoResponsavel ? "Entrada liberada" : "Entrada nao liberada";
Console.WriteLine(resultado);
*/
bool possuiPresencaMinima = true;
bool possuiMediaIgualOuMaiorQue7 = true;
string resultado = possuiPresencaMinima && possuiMediaIgualOuMaiorQue7 ? "Aprovado" : "Reprovado";
Console.WriteLine(resultado);

// Resolucao do professor
bool possuiPresencaMinima = true; 
double media = 6.0;

if(possiPresencaMinima && media >=7)
{ 
    Console.WriteLine($"Media {media:F1}: Aprovado");
}
else 
{
    Console.WriteLine($"Media {media:F1}: Reprovado");
}

bool choveu = true; 
bool estaTarde = true;
string resultado = !choveu && !estaTarde ? "Vou pedalar" : "Vou pedalar outro dia";
Console.WriteLine(resultado);

// Resolucao do professor
bool choveu = true;
bool estaTarde = false;
if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else 
{
    Console.WriteLine("Vou pedalar outro dia.");
}
