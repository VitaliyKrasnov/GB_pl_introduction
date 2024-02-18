namespace ConsoleApp1;

public class Task2
{
    public void RunTask()
    {
        Console.Write("Введите через пробел два неотрицательных числа 'm' и 'n': ");
        string[] range = Console.ReadLine()!.Split(" ");
        int m = Convert.ToInt32(range[0]);
        int n = Convert.ToInt32(range[1]);
        Console.WriteLine($"Значением функции Аккермана A({m},{n}) является число {Ackermann(m, n)}");
    }
    
    /// <summary>
    /// Вычисление значения функции Аккермана (https://rosettacode.org/wiki/Ackermann_function)
    /// </summary>
    /// <param name="m"> параметр 'm' в описании функции </param>
    /// <param name="n"> параметр 'n' в описании функции </param>
    /// <returns> значение функции Аккермана A(m, n) </returns>
    int Ackermann(int m, int n)
    {
        // Базовый случай
        if (m == 0)
        {
            return n + 1;
        }

        if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }

        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}