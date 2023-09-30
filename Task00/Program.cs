// Вывод символа n раз

string PrintString (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = PrintString (10, "Z");
Console.WriteLine(res);