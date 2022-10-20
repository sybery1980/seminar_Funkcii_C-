int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int sqrLengthX = (x2 - x1) * (x2 - x1);
int sqrLengthY = (y2 - y1) * (y2 - y1);
double distance = Math.Sqrt(sqrLengthX + sqrLengthY);
Console.WriteLine("Расстояние равно " + distance);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}