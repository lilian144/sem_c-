// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = -9
Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA + " ");
    Console.Write("min = ");
    Console.Write(numberB);
}
else 
{
    Console.Write("max = ");
    Console.Write(numberB + " ");
    Console.Write("min = ");
    Console.Write(numberA);
}