//Напишите программу , которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента или же указание, что такого элемента нет.

class Program
{
    static void Main(string[] args)
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Пример двумерного массива

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        if (row >= 0 && row < rowCount && column >= 0 && column < columnCount)
        {
            int value = array[row, column];
            Console.WriteLine($"Значение элемента [{row}, {column}] равно {value}");
        }
        else
        {
            Console.WriteLine("Такого элемента не существует");
        }

     
    }
}