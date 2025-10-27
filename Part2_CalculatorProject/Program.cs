using Part2_CalculatorProject;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating calculator
        Calculator calcAdd = new Calculator(8, 2, '+');
        Calculator calcSub = new Calculator(21, 5, '-');
        Calculator calcMult = new Calculator(10, 5, '*');
        Calculator calcDiv = new Calculator(7, 3, '/');

        Console.WriteLine($"8 + 2 = {calcAdd.Calculate()}");
        Console.WriteLine($"21 - 5 = {calcSub.Calculate()}");
        Console.WriteLine($"10 * 5 = {calcMult.Calculate()}");
        Console.WriteLine($"7 / 3 = {calcDiv.Calculate():F3}");
    }
}