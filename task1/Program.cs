// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

try
{
    Console.WriteLine("Enter a five digit integer number");
    double number = Convert.ToDouble(Console.ReadLine());

    //если число отрицательное, превращение в положительное
    if (number < 0)
    {
        Console.WriteLine("The number is negative, please enter a positive five-digit integer number");
    }
    else
    {
        //проверка пятизначности числа
        double numberTest = number / 10000;
        // Console.WriteLine(numberTest);

        if (numberTest > 10)
        {
            Console.WriteLine("The number is not a five digit integer number");
        }

        else if (numberTest < 1)
        {
            Console.WriteLine("The number is not a five digit integer number");
        }

        else
        {
            double rem5 = number % 10;
            double digit5 = 0;

            while (rem5 > 0)
            {
                rem5 = rem5 - 1;
                digit5 = digit5 + 1;
            }
            // Console.WriteLine($" The fifth digit is {digit5}");

            double rem4 = number % 100;
            double digit4 = 0;

            while (rem4 > 9)
            {
                rem4 = rem4 - 10;
                digit4 = digit4 + 1;
            }
            // Console.WriteLine($" The fourth digit is {digit4}");

            double rem2 = number % 10000;
            double digit2 = 0;

            while (rem2 > 999)
            {
                rem2 = rem2 - 1000;
                digit2 = digit2 + 1;
            }
            // Console.WriteLine($" The second digit is {digit2}");

            double rem1 = number % 100000;
            double digit1 = 0;

            while (rem1 > 9999)
            {
                rem1 = rem1 - 10000;
                digit1 = digit1 + 1;
            }
            // Console.WriteLine($" The first digit is {digit1}");

            if (digit5 == digit1 && digit4 == digit2)
            {
                Console.WriteLine("The number is a palindrome number");
            }

            else
            {
                Console.WriteLine("The number is NOT a palindrome number");
            }
        }
    }
}

catch
{
    Console.WriteLine("You have entered incorrect data, please restart the application and enter a five digit integer number");
}