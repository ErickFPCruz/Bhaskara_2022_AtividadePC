Console.Clear();

double variavel1, variavel2, variavel3, discriminante, resultado1, resultado2;
//variavel1 = a, variavel2 = b, variavel3 = c, discriminante = delta

Console.Write("Insira o número A: ");
variavel1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o número B: ");
variavel2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o número C: ");
variavel3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (variavel1 == 0)
{
    Console.WriteLine("Não é possível realizar esta operação!");
}
else
{
    discriminante = (Math.Pow(variavel2, 2)) - (4 * variavel1 * variavel3);

    if (discriminante < 0)
    {
        Console.WriteLine("Não é possível realizar esta operação!");
    }
    else
    {
        resultado1 = (-variavel2 + Math.Sqrt(discriminante)) / (2 * variavel1);
        Console.WriteLine($"x1 = {resultado1}");

        resultado2 = (-variavel2 - Math.Sqrt(discriminante)) / (2 * variavel1);
        Console.WriteLine($"x2 = {resultado2}");
        Console.WriteLine();
    }
}
Console.WriteLine("Operação Finalizada!");