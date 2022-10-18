// Задача 13:
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите  число: ");
string syb = Convert.ToString(Console.ReadLine());

    if(syb.Length >= 3)
    {
      Console.WriteLine(syb[2]);
    } 
        else
        {    
           Console.WriteLine("третьей цифры нет");
        }