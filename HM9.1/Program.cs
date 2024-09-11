Console.OutputEncoding = System.Text.Encoding.UTF8;
Random random = new Random();
Console.WriteLine("Програма 1:");
int[] Array = new int[random.Next(2, 10)];
for (int i=0; i<Array.Length-1;i++)
{
    Array[i] = random.Next(0,100);
}
int Temp;
bool isSorted = false;
int right = 1;
while (!isSorted)
{
    isSorted = true;
    for (int i = 0; i < Array.Length - right; i++)
    {
        
        if (Array[i] > Array[i + 1])
        {
            Temp = Array[i];
            Array[i] = Array[i + 1];
            Array[i + 1] = Temp;
            isSorted = false;
        }
    }
    right++;
}
Console.WriteLine($"Другий найбільший елимент масиву - {Array[Array.Length - 2]}");
Console.WriteLine("Програма 2:");
int[,] Array2D = new int[random.Next(2,5),random.Next(2,5)];
for (int i=0;i<Array2D.GetLength(0)-1;i++)
{
    for(int j=0;j<Array2D.GetLength(1)-1;j++)
    {
        Array2D[i,j] = random.Next(0,100);
    }
}
