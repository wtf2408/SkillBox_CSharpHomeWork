//Задание 1.Метод разделения строки на слова
Console.WriteLine("Введите предложение");
string sentence = Console.ReadLine();
string[] words = SplitSentence(sentence);
PrintText(words);
string[] SplitSentence(string sentence)
{
    string[] words = sentence.Split(" ");
    return words;
}
void PrintText(string[] text)
{
    foreach (var item in text)
    {
        Console.WriteLine(item);
    }
}
