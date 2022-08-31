// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("ВВедите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите число B");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;
for (int i = 1; i<b; i++)
{
stepen = stepen * a;
}
Console.WriteLine ("А в степени В равно : " + stepen);