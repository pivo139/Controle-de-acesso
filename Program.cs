// See https://aka.ms/new-console-template for more information

char operacao;

Console.WriteLine("Digite a operacao: ");

Console.WriteLine(" + ADICAO");
Console.WriteLine(" - SUBTRACAO");
Console.WriteLine(" * MULTIPLICACAO");
Console.WriteLine(" / DIVISAO");
Console.WriteLine();

Console.WriteLine("operação: ");
char.TryParse(Console.ReadLine(), out operacao);

Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine();

switch(operacao){
    
    case '+':
    Console.WriteLine("Resultado: " + (num1 + num2));
    break;

    case '-':
    Console.WriteLine("Resultado: " + (num1 - num2));
    break;

    case '*':
    Console.WriteLine("Resultado: " + (num1 * num2));
    break;

    case '/':
    Console.WriteLine("Resultado: " + (num1 / num2));
    break;
}

Console.WriteLine();
Console.WriteLine("Fim do programa!");
