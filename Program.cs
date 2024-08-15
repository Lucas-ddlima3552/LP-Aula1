//int numero = 10;
//double pi = 3.14;
//char letra = 'A';
//bool isTrue = true;
//string mensagem = "Olá, mundo!";
//
//int x;
//Console.WriteLine("Digite o valor de X:");
//
//x = Convert.ToInt32(Console.ReadLine());
//
////usando concatenação
//Console.WriteLine("O usuário digitou:  " + x + "Parabéns!");
//
////usando interpolação
//Console.WriteLine($"O usuário digitou {x}, parabéns!");
//
////usando placeRolders
//Console.WriteLine("O usuário digitou ", x, "Parabéns!");

//Passo a passo:
//Entrada de Dados:
//Peça ao usuário para inserir o primeiro número.
//Peça ao usuário para inserir o segundo número.
//Processamento:
//Realize cada uma das operações matemáticas básicas (adição, subtração, multiplicação e divisão) utilizando os dois números fornecidos pelo usuário.
//Exibição dos Resultados:
//Exiba os resultados das quatro operações, formatando-os de diferentes maneiras:
//Usando concatenação para uma das operações.
//Usando interpolação para outra.
//Usando placeholders para as restantes.

int primeiroNumero, segundoNumero;
int soma;
int subtracao;
double divisao;
int multiplicacao;

Console.WriteLine("Digite o valor do primeiro número:");
primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo número");
segundoNumero = Convert.ToInt32(Console.ReadLine());

soma = primeiroNumero + segundoNumero;
Console.WriteLine($"O valor da soma entre {primeiroNumero} e {segundoNumero} é igual a {soma}");

subtracao  = primeiroNumero - segundoNumero;
Console.WriteLine("O valor da subtração entre " + primeiroNumero + " e " + segundoNumero + " é igual a " + subtracao);

divisao = (double) primeiroNumero / segundoNumero;
Console.WriteLine($"O valor da divisao entre {primeiroNumero} e {segundoNumero} é igual a {divisao}");

multiplicacao = primeiroNumero * segundoNumero;
Console.WriteLine("O valor da multiplicação entre {0} e {1} é igual a {2}", primeiroNumero, segundoNumero, multiplicacao);

