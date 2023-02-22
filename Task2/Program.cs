string[] SplitSentence(string sentence)
{
    string[] words = sentence.Split(" ");
    return words;
}
string[] ReverseText(string text)
{
    string[] words = SplitSentence(text);
    int count = words.Length - 1;
    string[] wordsReverse = new string[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        wordsReverse[i] = words[count];
        count--;
    }
    return wordsReverse;
}

Console.WriteLine("Введите предложение");
string text = Console.ReadLine();

string[] wordsReverse = ReverseText(text);
foreach (var item in wordsReverse)
{
    Console.Write($"{item} ");
}