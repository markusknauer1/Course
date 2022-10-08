/*
 int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];

for (int i = 0; i < n; i++) //leitura por linha
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++) //leitura por coluna
    {
        mat[i, j] = int.Parse(values[j]);
    }
}
Console.WriteLine("Main diagonal: "); // leitura de numeros da diagonal principal
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

int count = 0; // leitura de numeros negativos
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine("negative numbers: " + count);
 */