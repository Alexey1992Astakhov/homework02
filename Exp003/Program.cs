//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Random random = new Random();
    int finishnumber = random.Next(1, 11);
    int startnumber = 1;
    Console.WriteLine(finishnumber);
    while (startnumber <= finishnumber)
    {
        Console.WriteLine((Math.Pow(startnumber, 3)));
        startnumber++;
    }