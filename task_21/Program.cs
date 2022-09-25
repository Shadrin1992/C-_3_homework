// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите три координаты первой точки через ',' и без пробелов");
string num1 = Convert.ToString(Console.ReadLine());

int[] arr1 = num1.Split(',').Select(int.Parse).ToArray();

Console.WriteLine("Введите три координаты второй точки через ',' и без пробелов");
string num2 = Convert.ToString(Console.ReadLine());

int[] arr2 = num2.Split(',').Select(int.Parse).ToArray();

double d = Math.Round(Math.Sqrt(
    Math.Pow((arr2[0]-arr1[0]), 2) 
    + Math.Pow((arr2[1]-arr1[1]), 2)
    + Math.Pow((arr2[2]-arr1[2]), 2)), 2);

Console.WriteLine("Расстояние между точками: " + d);
