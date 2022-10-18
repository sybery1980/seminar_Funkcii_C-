//Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1
//s = (n / 10) % 10
Console.Write("Введите трехзначное число: ");
string syb = Convert.ToString(Console.ReadLine());

    if(syb.Length >= 3)
    {
      Console.WriteLine(syb[1]);
    } 
        else
        {    
           Console.WriteLine("Число не трехзначное");
        }