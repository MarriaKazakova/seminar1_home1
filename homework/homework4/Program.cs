Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int i = 2; i <= num; i=i+2)
        {
                numbers.Add(i);
        }
        Console.WriteLine("Вот ваш список:");
        foreach (int number in numbers)
        {
            Console.Write(" " + number);
        }
