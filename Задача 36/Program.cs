// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

// Создаем экземпляр класса Random для генерации случайных чисел
        Random random = new Random();

        // Размер массива
        int size = 10;

        // Создаем массив заданного размера
        int[] array = new int[size];

        // Заполняем массив случайными числами
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 10);
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Находим сумму элементов, стоящих на нечетных позициях
        int sum = 0;
        for (int i = 1; i < size; i += 2)
        {
            sum += array[i];
        }

        // Выводим сумму
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

        
        Console.ReadLine();