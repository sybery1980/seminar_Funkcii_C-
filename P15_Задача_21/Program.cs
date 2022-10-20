Console.WriteLine("Введите координаты точки А:");

int ax = Convert.ToInt32(Console.ReadLine());
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");

int bx = Convert.ToInt32(Console.ReadLine());
int by = Convert.ToInt32(Console.ReadLine());

int sqrLength = (ax - bx ) * (ax - bx) + (ay - by) * (ay - by);

double result = Math.Sqrt(sqrLength);
Console.WriteLine(result);



