// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

 Random random = new Random();
    int x1 = random.Next(-10, 11);
    int y1 = random.Next(-10, 11);
    int x2 = random.Next(-10, 11);
    int y2 = random.Next(-10, 11);
    int z1 = random.Next(-10, 11);
    int z2 = random.Next(-10, 11);
    Console.WriteLine($"Первая точка с координатами ({x1}, {y1}, {z1})\nВторая точка с координатами ({x2}, {y2}, {z2})");
    Math.Pow((y2-y1), 2);
    int result=(int)Math.Pow(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)+Math.Pow((z2-z1), 2), 1.0/2);
    Console.WriteLine($"Расстояние между точками {result}");