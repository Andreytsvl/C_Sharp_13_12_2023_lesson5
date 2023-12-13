// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
class Program
{
    static void Main(string[] args)
    {
       
        Random random = new Random();

     
        int rowCount = 5;
        int columnCount = 5;

        int[,] array = new int[rowCount, columnCount];

       
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < columnCount; j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }

      
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

      
        for (int j = 0; j < columnCount; j++)
        {
            int temp = array[0, j];
            array[0, j] = array[rowCount - 1, j];
            array[rowCount - 1, j] = temp;
        }

        // Выводим измененный массив на экран
        Console.WriteLine("Массив после замены:");
        PrintArray(array);


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