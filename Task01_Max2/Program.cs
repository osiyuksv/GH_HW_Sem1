// программа, 2 числа на вход, на выходе макс и мин
Console.WriteLine("Введите первое чиcло");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чиcло");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;

if(number1 > number2)
{
max = number1;
min = number2;
}
else
{
max = number2;
min = number1;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
