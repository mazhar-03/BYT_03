namespace Part2_CalculatorProject;

public class Calculator
{
    public double A;
    public double B;
    public char Operation;

    public Calculator(double a, double b, char operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        double result = 0;
        switch (Operation)
        {
            case '+':
                result = A + B;
                break;
            case '-':
                result = A - B;
                break;
            case '*':
                result = A * B;
                break;
            case '/':
                if (B == 0)
                    throw new DivideByZeroException("Cannot divide by zero.");
                result = A / B;
                break;
            default:
                throw new InvalidOperationException("Invalid operation");
        }
        return result;
    }
}