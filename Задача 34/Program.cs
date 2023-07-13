// Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

 // Создаем объект генератора случайных чисел
        Random random = new Random();

        // Задаем размер массива
        int size = 10;

        // Создаем и заполняем массив случайными положительными трехзначными числами
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        // Подсчитываем количество четных чисел
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество четных чисел: " + count);

        
        Console.ReadLine();