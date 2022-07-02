// Задать случайный двумерный массив размером N x M, заполненный случайными числами


int m = 3, n = 4;
int[,] mass = new int[m,n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        //Console.Write(i + " " + j + ", ");
        mass[i,j] = new Random().Next(-99,100);
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}