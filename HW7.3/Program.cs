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



int[,] array = TwoDimensionalArray(3,4);
PrintArray(array);

double sum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum += array[j,i];
    }
    double result = sum / array.GetLength(1);
    int num = i+1;
    Console.WriteLine("Среднеарифмитическое " +num+ " столба: " +result);
    sum = 0;
}