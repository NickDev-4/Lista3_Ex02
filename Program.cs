Console.Clear();

double salario, total;

Console.Write("Digite o seu salário: ");
salario = double.Parse(Console.ReadLine());

total = salario * 0.08;

Console.WriteLine("");

Console.WriteLine("Salário (R$)..: {0}", salario);

Console.WriteLine("FGTS: R$ {0:f2}", total);