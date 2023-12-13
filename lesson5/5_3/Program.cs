// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов,
// выводить массив и указывать индекс этой строки.

class Program
{
    static void Main(string[] args)
    {
       
        int[,] array = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

      
        int minSumRowIndex = 0;
        int minSum = int.MaxValue;

      
        for (int i = 0; i < array.GetLength(0); i++)  
        {
            int currentSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)  
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

       
        Console.WriteLine("Массив:");
        PrintArray(array);

     
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex}");


    }

  
    static void PrintArray(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                Console.Write($"{array[i, j]} ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}