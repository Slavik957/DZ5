//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


 // Создаем массив вещественных чисел
        double[] numbers = { 1.5, -2.3, 4.7, 3.1, -0.5 };

        // Находим максимальный элемент массива
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Находим минимальный элемент массива
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;
        Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);