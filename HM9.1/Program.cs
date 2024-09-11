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
for (int i=0;i<Array2D.GetLength(0);i++)
{
    for(int j=0;j<Array2D.GetLength(1);j++)
    {
        Array2D[i,j] = random.Next(0,100);
    }
}
Console.WriteLine("Двовимірний масив до сортировки:");
for (int i = 0; i < Array2D.GetLength(0); i++)
{
    for (int j = 0; j < Array2D.GetLength(1); j++)
    {
        Console.Write($"{Array2D[i, j]} ");
    }
    Console.WriteLine();
}

bool isSorted2 = false;
int Temp2;
int line = Array2D.GetLength(0);
int column = Array2D.GetLength (1);
int right2 = 1;

while (!isSorted2)
{
    isSorted2 = true;
    for(int i=0;i<line*column-right2;i++)
    {
        int line1 = i / column;
        int column1 =i % column;
        int line2 = (i+1)/column;
        int column2 = (i + 1) % column;
        if (Array2D[line1,column1]> Array2D[line2,column2])
        {
            Temp2 = Array2D[line1, column1];
            Array2D[line1, column1] = Array2D[line2, column2];
            Array2D[line2, column2]=Temp2;
            isSorted2 = false;

        }
    }
    right++;
}
Console.WriteLine("Двовимірний масив после сортировки:");
for (int i = 0; i < Array2D.GetLength(0); i++)
{
    for (int j = 0; j < Array2D.GetLength(1); j++)
    {
        Console.Write($"{Array2D[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Програма 3:");

int[] Array3 = new int[10];
int[] Array4 = new int[9];
int index4 = 0;

for (int i = 0;i < Array3.Length;i++)
{
    Array3[i] = random.Next(0,100);
}
Console.Write("Введіть індекс видаляймого елемента:");
int deleteindex = int.Parse(Console.ReadLine());
for (int i = 0;i<Array3.Length;i++)
{
    if (i != deleteindex)
    {
        Array4[index4] = Array3[i];
        index4++;
    }
}
for (int i = 0;i<Array3.Length;i++)
{
    Console.Write($"{Array3[i]} ");
}
Console.WriteLine();
for (int i = 0; i < Array4.Length; i++)
{
    Console.Write($"{Array4[i]} ");
}
Console.WriteLine("Програма 4:");
int val = random.Next(2, 5);
int[,] array2D = new int[6, 6];
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        array2D[i, j] = random.Next(0, 100);
    }
}
int sum = 0;
for (int i = 0; i < array2D.GetLength(1); i++)
{
    sum += array2D[i, i];
}
Console.WriteLine("Двовимырний масив:");
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        Console.Write($"{array2D[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Сумма діагональних елементів: {sum}.");