//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
string size = Convert.ToString(a);
int index = size.Length;
int sum = 0;
int prom = 0;
for (int i = 0; i < index; i++)
{
   prom = a - a % 10;
   sum = sum + (a - prom);
   a = a / 10;
}
Console.WriteLine(sum);
