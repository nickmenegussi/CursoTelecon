// tipos de dados inteiros, double, float, decimal, strings, boolean em c#
int numero = 4; // inteiro
double segundoNumero = 3.304;
char primeiraLetraNome = 'L';
String nomeCompleto = "Nicolas Menegussi Ramos";
bool isOverEighteenYears = false;

Console.WriteLine(numero);
Console.WriteLine(segundoNumero);
Console.WriteLine(primeiraLetraNome);
Console.WriteLine(nomeCompleto);
Console.WriteLine(isOverEighteenYears);

// pedindo pro usuario digitar algo e depois imprimir na tela o resultado.
Console.WriteLine("Digite seu nome: ");
String nomeUser = Console.ReadLine();
Console.WriteLine("Seja Bem-Vindo, " + nomeUser + "!");
