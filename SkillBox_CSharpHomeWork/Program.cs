﻿using SkillBox_CSharp;

#region Тернарный оператор
//Random random = new Random();
//int a = random.Next(1, 10);
//Console.WriteLine(a);
//Console.WriteLine((a > 5) ? "больше 5":"меньше 5");
#endregion

#region Switch-case
//int day = Convert.ToInt32(Console.ReadLine());
//switch (day)
//{
//	case 1:
//		Console.WriteLine("Пн");
//		break;
//    case 2:
//        Console.WriteLine("Вт");
//        break;
//    case 3:
//        Console.WriteLine("Ср");
//        break;
//    case 4:
//        Console.WriteLine("Чт");
//        break;
//    case 5:
//        Console.WriteLine("Пт");
//        break;
//    case 6:
//        Console.WriteLine("Сб");
//        break;
//    case 7:
//        Console.WriteLine("Вс");
//        break;
//    default:
//        Console.WriteLine("Нет такого дня");
//        break;
//}
#endregion

#region Зубчатый массив
//int[][] arr = new int[3][];
//arr[0] = new int[2];
//arr[0][0] = 1;
//arr[0][1] = 2;
//arr[1] = new int[] { 1, 2, 3 };
//arr[2] = new int[] { 1, 2, 3, 4 };
//for (int i = 0; i < arr.Length; i++)
//{
//	for (int j = 0; j < arr[i].Length; j++)
//	{
//		Console.Write($"{arr[i][j]} ");
//	}
//	Console.WriteLine();
//}
//foreach (var array in arr)
//{
//	foreach (var item in array)
//	{
//		Console.Write($"{item} ");
//	}
//	Console.WriteLine();
//}
#endregion

#region DateTime
//Console.WriteLine(DateTime.Now);// время на сег. момент
//Console.ReadLine();
#endregion

#region Работа с файлами


//string words = "Hello my name is";

////File.WriteAllText(@"D:\testFile", words);
//File.AppendAllText(@"D:\testFile", " Bogdan");
//string path = @"D:\ЕГЭинформ";

//DirectoryInfo directory = new DirectoryInfo(path);
//Console.WriteLine(directory.FullName);
//foreach (var dir in directory.GetDirectories())
//{
//    Console.WriteLine("   " + dir.Name);
//	foreach (var file in dir.GetFiles())
//	{
//		Console.WriteLine("    " + file.Name);
//	}
//}

#endregion

#region Структуры


MonthReport[] monthReport = new MonthReport[3];


monthReport[1] = new MonthReport("Февраль", 70000, 20000);

Console.WriteLine(monthReport[1].Expense);
Console.WriteLine(monthReport[1].Print());



#endregion