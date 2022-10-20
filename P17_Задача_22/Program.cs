int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (number <= 0)
{
    number = - number;
   
}
 while (count <= number)
 {
    Console.WriteLine(count * count);
    count++;

 }
