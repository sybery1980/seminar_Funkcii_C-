// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.


Console.Write("Введите  число: ");
int syb = Convert.ToInt32(Console.ReadLine());
int weekend = 6;
int max = 8;

if(syb >= weekend && syb >= max  )
    {
        Console.WriteLine(" Недопустимое значение");
    }
        else if(syb < weekend)
    { 
        Console.WriteLine(" Будний день");
    }             
        else
    {
        Console.WriteLine(" Выходной день");
    }