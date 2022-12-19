// выводим макс из трёх чисел

Console.WriteLine("Введите первое чиcло");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чиcло");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье чиcло");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.Write("max = ");
Console.WriteLine(max);
