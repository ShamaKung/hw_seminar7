int[,] array = new int[3, 4];

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine("");
}

Console.WriteLine("Введите координаты");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > 3 && b > 4) Console.WriteLine("такого числа нет");
else
{
object c = array.GetValue(a, b);
Console.WriteLine(c);
}