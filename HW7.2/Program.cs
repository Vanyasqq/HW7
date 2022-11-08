int[,] TwoDimensionalArray(int a, int b)
{
    int[,] array = new int[a, b];

    Random rnd = new Random();

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array [i,j] = rnd.Next(0,10); 
        } 
    }  
    return array;
}  

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }            
    Console.WriteLine();
    }
}

int Promt(string msg)
{
    Console.WriteLine(msg);
    int count = int.Parse(Console.ReadLine()); 
    return count;
}

int n = Promt("Введите кол-во строк");
int m = Promt("Введите кол-во столбцов");
int[,] array = TwoDimensionalArray(n,m);
PrintArray(array);



int x = Promt("Введите номер строки");
int z = Promt("Введите номер столбика");

if (x<=n)
{
    if (z<=m)
    {
        Console.WriteLine(array[x-1,z-1]);
    }
    else
    {
    Console.WriteLine("такого столбика нет");
    }
}
else
{
    Console.WriteLine("такой строки нет");
}




