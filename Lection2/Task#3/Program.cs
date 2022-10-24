// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         Console.Write($"{i*j}\t");
//     }
//     Console.WriteLine();
// }

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,n];
for (int i = 1; i <= n; i++)
{
    for (int j = i; j <= n; j++)
    {
        matrix[i-1,j-1] = i*j;
        matrix[i-1,j-1] = i*j;
    }
}
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        Console.Write($"{i*j}\t");
    }
    Console.WriteLine();
}