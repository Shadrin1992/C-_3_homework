// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число");
string number = Convert.ToString(Console.ReadLine());

int[] array = new int[number.Length];
int i;

for(i = 0; i < number.Length; i++)
{
    array[i] = Convert.ToInt32(number[i].ToString());
}
if(number.Length != 5)
{
    Console.WriteLine("Неверное число");
}
else if(number[0] == number[4] & number[1] == number[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}