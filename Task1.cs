namespace ConsoleApp1;

public class Task1
{
    public void RunTask()
    {
        Console.Write("Введите через пробел числа M и N: ");
        string[] range = Console.ReadLine()!.Split(" ");
        int start = Convert.ToInt32(range[0]);
        int end = Convert.ToInt32(range[1]);
        ShowNumbers(start, end);
    }

    /// <summary>
    /// Метод печатает все числа от start до end
    /// </summary>
    /// <param name="start"> начало дипазаона натуральных чисел </param>
    /// <param name="end"> конец диапазана натуральных чисел </param>
    void ShowNumbers(int start, int end)
    {
        // Базовый случай
        if (start == end)
        {
            Console.WriteLine(start);
            return;
        }

        // Рекурсивный случай
        Console.Write(start + " ");
        ShowNumbers(start + 1, end);
    }
}