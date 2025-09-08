using System;

class Calculator
{
    private double currentNumber;  
    private double memoryNumber;   

    public Calculator()
    {
        currentNumber = 0;
        memoryNumber = 0;
    }

    public void Addition(double number)
    {
        currentNumber += number;
    }

    public void Subtraction(double number)
    {
        currentNumber -= number;
    }

    public void Multiplication(double number)
    {
        currentNumber *= number;
    }

    public void Division(double number)
    {
        if (number == 0)
        {
            Console.WriteLine("Ошибка! Деление на ноль строго запрещено!");
        }
        else
        {
            currentNumber /= number;
        }
    }

    public void Percents(double number)
    {
        currentNumber = (currentNumber * number) / 100;
    }

    public void Drob()
    {
        if (currentNumber == 0)
        {
            Console.WriteLine("Ошибка! Деление на ноль строго запрещено!");
        }
        else
        {
            currentNumber = 1 / currentNumber;
        }
    }

    public void Square()
    {
        currentNumber *= currentNumber;
    }

    public void SQRT()
    {
        if (currentNumber < 0)
        {
            Console.WriteLine("Ошибка! Нельзя извлечь корень из отрицательного числа!");
        }
        else
        {
            currentNumber = Math.Sqrt(currentNumber);
        }
    }
    public void MemoryAddition()
    {
        memoryNumber += currentNumber;
    }

    public void MemorySubtraction()
    {
        memoryNumber -= currentNumber;
    }

    public void MR()
    {
        currentNumber = memoryNumber;
    }

    public void MemoryCleaner()
    {
        memoryNumber = 0;
        Console.WriteLine("Память очищена");
    }
    public void SetNumber(double number)
    {
        currentNumber = number;
    }

    public double GetCurrentNumber()
    {
        return currentNumber;
    }

    public void Display()
    {
        Console.WriteLine($"Текущее значение: {currentNumber}");
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR, MC");
        Console.WriteLine("Введите 'exit' для выхода");
        Console.WriteLine();

        while (true)
        {
            calculator.Display();
            Console.Write("Введите операцию: ");
            string operation = Console.ReadLine();

            if (operation == "exit") break;

            try
            {
                switch (operation)
                {
                    case "+":
                        Console.Write("Введите число для сложения: ");
                        calculator.Addition(Convert.ToDouble(Console.ReadLine()));
                        break;

                    case "-":
                        Console.Write("Введите число для вычитания: ");
                        calculator.Subtraction(Convert.ToDouble(Console.ReadLine()));
                        break;

                    case "*":
                        Console.Write("Введите число для умножения: ");
                        calculator.Multiplication(Convert.ToDouble(Console.ReadLine()));
                        break;

                    case "/":
                        Console.Write("Введите число для деления: ");
                        calculator.Division(Convert.ToDouble(Console.ReadLine()));
                        break;

                    case "%":
                        Console.Write("Введите процент: ");
                        calculator.Percents(Convert.ToDouble(Console.ReadLine()));
                        break;

                    case "1/x":
                        calculator.Drob();
                        break;

                    case "x^2":
                        calculator.Square();
                        break;

                    case "sqrt":
                        calculator.SQRT();
                        break;

                    case "M+":
                        calculator.MemoryAddition();
                        break;

                    case "M-":
                        calculator.MemorySubtraction();
                        break;

                    case "MR":
                        calculator.MR();
                        break;

                    case "MC":
                        calculator.MemoryCleaner();
                        break;

                    default:
                        Console.WriteLine("Неизвестная операция!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите корректное число!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine();
        }

        
    }
}

