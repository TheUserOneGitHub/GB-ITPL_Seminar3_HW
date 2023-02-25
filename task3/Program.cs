//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Enter a natural number");

try
{
    double number = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Table of cubes of natural numbers from 1 to {number}:");
    if (number % 1 == 0 && number > 0)
    {
        long numberArray = 0;
        long numberCube = 0;
        while (numberArray < number)
        {
            numberArray = numberArray + 1;
            numberCube = numberArray * numberArray * numberArray;
            Console.WriteLine(numberCube);
        }
    }

    else
    {
        Console.WriteLine($"Number {number} is not a natural, please restart the application and enter a natural number");
    }
}

catch
{
    Console.WriteLine("You have entered incorrect data, please restart the application and enter a natural number");
}