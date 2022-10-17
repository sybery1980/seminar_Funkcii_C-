//решение 0
int min = 100;  
int max = 999;
int randomNumber = new Random().Next(min, max + 1); //Найти случайное число от 100 до 1000

Console.WriteLine(randomNumber);    

int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 10; // сложение рендомных остатков

Console.Write(firstDigit);
Console.Write(secondDigit);
//решение 1
//int min = 100;
//int max = 999;
//int randomNumber = new Random().Next(min, max + 1);

//int firstDigit = randomNumber / 100;
//int lastDigit = randomNumber % 10;

//Console.WriteLine($"{randomNumber} -> {firstDigit}{lastDigit}")


//решение 2
//int min = 100;
//int max = 999;
//int randomNumber = new Random().Next(min, max + 1);

//int firstDigit = randomNumber / 100;
//int lastDigit = randomNumber % 10;

//Console.Write(firstDigit);
//Console.WriteLine(lastDigit);


//решение 3
//int min = 100;
//int max = 999;
//int randomNumber = new Random().Next(min, max + 1);

//int firstDigit = randomNumber / 100;
//int lastDigit = randomNumber % 10;

//int result = firstDigit * 10 + lastDigit;
//Console.WriteLine(result);

