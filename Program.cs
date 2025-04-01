/*
Calcule a parcela do FGTS sobre o salário de um funcionário (8%).

Salário (R$)..: 2000,00

FGTS: R$ 160,00
*/

double porcentagemFGTS = 0.08;
Console.WriteLine("Informe seu salário:");
double salario = Convert.ToDouble(Console.ReadLine());
double resultado = salario * porcentagemFGTS;
Console.WriteLine($"O FGTS com base no salário informado é de: {resultado} reais.");
