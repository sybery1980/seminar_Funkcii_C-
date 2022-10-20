//Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1
//s = (n / 10) % 10
int InputNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int inputNumber = InputNumber("Введите 3-х значное число: ");

int syb = (inputNumber % 100) / 10;

Console.WriteLine("\nВ числе "+ inputNumber + "\nВторое число " + syb + "\n");