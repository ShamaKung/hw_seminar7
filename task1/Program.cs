Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
        Console.Write("{0}\t", Math.Round(array[i, j], 3));
    }
    Console.WriteLine("");
}