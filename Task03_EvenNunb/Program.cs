// программа, определяет чётность числа
Console.WriteLine("Введите чиcло");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
Console.Write(number);
Console.WriteLine(" - это чётное число");
}
else
{
Console.Write(number);
Console.WriteLine(" - это НЕчётное число");
}
