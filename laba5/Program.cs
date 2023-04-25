using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию (+, -, *, /):");
        char op = char.Parse(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Неверная операция");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}

