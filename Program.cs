internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 99 || number > 999)
        {
            Console.WriteLine("Введите трехзначное число ");
            return;
        }

        else
        {
            int secondNumber = number % 100 / 10;
            Console.WriteLine(secondNumber);
        }
    }
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет(Читерский способ)

internal class NexProgram
{
    private static void Main(string[] args)
    {
        int number = ReadInt("Введите число: ");
        int count = number.ToString().Length;
        Console.Write(MakeArray(number, count));

        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        int MakeArray(int a, int b)
        {
            int result = 0;
            if (b < 3)
            {
                Console.Write("Третьей цифры нет ");
            }
            else
            {
                int c = 1;
                for (int i = b; i > 3; i--)
                {
                    c = c * 10;
                }

                result = a / c % 10;
            }
            return result;
        }
    }
}



internal partial class alsoProgramm
{
    private static void Main(string[] args)
    {
        //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0 || number > 7)
        {
            Console.Write("Это не день недели");
            return;
        }
        if (number == 6 || number == 7)
        {
            Console.Write("Это выходной");
        }
        else
        {
            Console.Write("Это рабочий день");
        }
    }
}
