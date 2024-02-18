namespace ConsoleApp1;

public class Task3
{
    public void RunTask()
    {
        Console.Write("Введите через пробел элементы массива: ");
        string[] array = Console.ReadLine()!.Split(" ");
        Console.Write($"Массив в обратном порядке: ");
        ReverseArray(array, array.Length - 1);
    }

    /// <summary>
    /// Выводит массив в обратном порядке
    /// </summary>
    /// <param name="array"> массив элементов </param>
    /// <param name="index"> индекс массива который будет напечатан </param>
    void ReverseArray(string[] array, int index)
    {
        if (index == 0)
        {
            Console.WriteLine(array[index]);
        }
        else
        {
            Console.Write($"{array[index]} ");
            ReverseArray(array, index - 1);
        } 
    }
}