// на входе число N, на выходе список всех чётных от 1 до N
Console.WriteLine("Введите чиcло");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count < number)
{
if(count % 2 == 0) 
{
  Console.Write(count);
  Console.Write("; ");
}
count ++;
}
