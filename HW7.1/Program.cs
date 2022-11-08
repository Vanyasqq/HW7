void TwoDimensionalArray(int a, int b)
{
    int[,] array = new int[a, b];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(0,100); 
        } 
    }    

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} "); 
        }            
    Console.WriteLine();
    }
}



TwoDimensionalArray(3,5);

