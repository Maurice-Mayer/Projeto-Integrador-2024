// See https://aka.ms/new-console-template for more information

// Protótipo 1

// Console.WriteLine("OLá Mundo");
// Console.WriteLine("Leo Andrade");

// Protótipo 2

// var resultado = 20 - 10;
// Console.WriteLine(" Resultado " + resultado);

// Exercício Principal

// Começamos pedindo para o usuário entrar com as 4 notas necessárias
// Perceba que colocamos uma exibição antes de cada entrada de dados apenas para na rodagem do programa fazer mais sentido uma "instrução" para o usuário.
// Usamos int.parse para converter a entrada string do teclado em número inteiro.
// E também o comando console.readline() para a entrada do dado.

Console.WriteLine("DIGITE A PRIMEIRA NOTA: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("DIGITE A SEGUNDA NOTA: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("DIGITE A TERCEIRA NOTA: ");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("DIGITE A QUARTA NOTA: ");
int n4 = int.Parse(Console.ReadLine());

// Agora presisamos calcular a média.
// Somando as quatro notas dividindo pela quantidade de notas.

double media = (n1 + n2+ n3+ n4) / 4;

// Agora entramos com o "escolha caso". 
// Se algo faça isso, Se outra coisa faça aquilo.
// Repare que "if ele executa uma coisa e "else" ele executa outra coisa.
// Perceba também a váriável "media" sendo ou não < (maior) que 7 rodando junto ao "else" executando "APROVADO".
// Sendo < (menor) ele cai para a execução else executando a mensagem "REPROVADO".

if(media > 7)
{
    Console.WriteLine("APROVADO. ");
}
else 
{
    Console.WriteLine("REPROVADO. ");
}
// Aqui chegamos ao fim do programa.








