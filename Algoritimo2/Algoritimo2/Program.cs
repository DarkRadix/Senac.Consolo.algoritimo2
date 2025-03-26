int idade = 10;
string nomeCliente = "Rafael Soarez";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Rafael Suarez";
var altura = 180;
Console.Write("Digite seu nome:");
nomeCompleto = Console.ReadLine();
Console.WriteLine("Bem Vindo " + nomeCompleto);
Console.Write("Digite sua Idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade Informada " + idade);
if (idade < 18)
    Console.WriteLine("Você não pode estar aqui!");

Console.ReadKey();
