int number = Convert.ToInt32(Console.ReadLine());
if(number < 1 || number > 4)
{
    Console.WriteLine("Такой четверти нет");
    return;
}
if(number == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}

else if(number == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else if(number == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}

else if(number == 4)
{
    Console.WriteLine("x > 0 и y < 0");
    
}