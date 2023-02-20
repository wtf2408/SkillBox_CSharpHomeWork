#region Тернарный оператор
Random random = new Random();
int a = random.Next(1, 10);
Console.WriteLine(a);
Console.WriteLine((a > 5) ? "больше 5":"меньше 5");
#endregion

#region Switch-case
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
	case 1:
		Console.WriteLine("Пн");
		break;
    case 2:
        Console.WriteLine("Вт");
        break;
    case 3:
        Console.WriteLine("Ср");
        break;
    case 4:
        Console.WriteLine("Чт");
        break;
    case 5:
        Console.WriteLine("Пт");
        break;
    case 6:
        Console.WriteLine("Сб");
        break;
    case 7:
        Console.WriteLine("Вс");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
}
#endregion


