#region Задание 1. Приложение по определению чётного или нечётного числа
//Напишите приложение, которое определяет чётное или нечётное число.
//Console.WriteLine("Введите число:");
//int userNumber = Convert.ToInt32(Console.ReadLine());
//if (userNumber % 2 == 0) Console.WriteLine("Число четное");
//else Console.WriteLine("Число не четное");
#endregion

#region Задание 2. Программа подсчёта суммы карт в игре «21»
//Программа подсчёта суммы карт в игре «21»
//Console.WriteLine("Игра 21");
//Console.WriteLine("\nДобро пожаловать, сколько карт у вас на руках?");
//int countCards = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Пожайлуста, введите номинал каждой карты\n" +
//        "Для карт с числовым номиналом введите только цифру.\n" +
//        "Для картинок следует принять обозначения латинскими буквами:\n" +
//        "Валет = J\n" +
//        "Дама = Q\n" +
//        "Король = K\n" +
//        "Туз = T");
//int weightCards = 0;
//for (int i = 0; i < countCards; i++)
//{
//    string cart = Console.ReadLine().ToUpper();
//    switch (cart)
//    {
//        case "J":
//            weightCards += 10;
//            break;
//        case "Q":
//            weightCards += 10;
//            break;
//        case "K":
//            weightCards += 10;
//            break;
//        case "T":
//            weightCards += 10;
//            break;
//        default:
//            weightCards += Convert.ToInt32(cart);
//            break;
//    }
//}
//Console.WriteLine($"Вес ваших карт равен {weightCards}");
#endregion

#region Задание 3. Проверка простого числа
//Console.WriteLine("Введиет целое число:");
//int inputNumber = Convert.ToInt32(Console.ReadLine());
//int counter = 2;
//bool result = true;
//while (counter != inputNumber)
//{
//    if (inputNumber % counter == 0)
//    {
//        result = false;
//        break;
//    }
//    counter++;
//}
//if (result) Console.WriteLine("Число простое");
//else Console.WriteLine("Число не является простым");
#endregion

#region Задание 4. Наименьший элемент в последовательности
//Console.WriteLine("Введите длину последовательности:");
//int length = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[length];
//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine($"Введите {i + 1} число:");
//    array[i] = Convert.ToInt32(Console.ReadLine());
//}
//int min = array[0];
//for (int j = 0; j < array.Length; j++)
//{
//    if (array[j] < min) min = array[j];
//}
//Console.WriteLine($"Минимальный элемент последовательности - {min}");
#endregion

#region Задание 5. Игра «Угадай число»
//Console.WriteLine("Игра - Угадай число\nВведите максимальное целое число диапозона:");
//int inputMax = Convert.ToInt32(Console.ReadLine());
//Random random = new Random();
//int hiddenNumber = random.Next(0, inputMax + 1);
//while (true)
//{
//    Console.WriteLine("Введите предполагаемое число:");
//    string inputNumber = Console.ReadLine();
//    if (inputNumber == " ")
//    {
//        Console.WriteLine("Игра завершена, возвращайтесь!");
//        break;
//    }
//    else if (hiddenNumber > Convert.ToInt32(inputNumber)) Console.WriteLine("Загаданное число больше");
//    else if (hiddenNumber < Convert.ToInt32(inputNumber)) Console.WriteLine("Загаданное число меньше");
//    else if (hiddenNumber == Convert.ToInt32(inputNumber))
//    {
//        Console.WriteLine("Позравляем, вы угадали!");
//        break;
//    }
//}
#endregion