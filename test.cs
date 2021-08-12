using System;
class Program
{
    public static void TaskOne(int num)
    {
        if (num > 7)
        {
            Console.WriteLine("Привет");
        }
    }

    public static void TaskTwo(string name)
    {
        if (name == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
        else
            {
                Console.WriteLine("Нет такого имени");
            }
    }

    public static void TaskThree(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
            if (numbers[i] % 3 == 0)
            {
                Console.Write($"{numbers[i]} ");
            }
    }

    static void Main()
    {
        Console.WriteLine("Введите число для первого задания ");
        //пожалуйста не вводите ничего кроме чисел
        int number = Convert.ToInt32(Console.ReadLine());
        TaskOne(number);

        Console.WriteLine("Введите имя для второго задания ");
        string name = Console.ReadLine();
        TaskTwo(name);

        Console.WriteLine("Введите 5 чисел для третьего задания ");
        int[] numbers = new int[5];
        //int[] numbers = new int [] {2, 3, 4, 5, 6};
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        TaskThree(numbers);
    }
}

/*
    Дана скобочная последовательность: [((())()(())]]
    1.- Можно ли считать эту последовательность правильной?
        -Нет
    2.- Если ответ на предыдущий вопрос “нет” - то что необходимо в ней изменить, чтоб она стала правильной?
        -Добавить открывающую квадратную скобку "[" слева,
        -Добавить закрывающую круглую скобку ")"справа
*/