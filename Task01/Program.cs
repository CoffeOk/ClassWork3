/* 
В заданном тексте:
1. Все пробелы зименить любой чертой
2. Маленькие буквы "к" заменить большими
3. Большие бюуквы "С" заменить маленькими
 */

string text1 = "- Я думаю, – сказал князь, улыбаясь, – что," 
                + "ежели бы вас послали вместо нашего милого Винценгероде, "
                + "вы бы взяли приступом согласие прусского короля. "
                + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace (text1, ' ', '|');
string newText1 = Replace (newText, 'к', 'К');
string newText2 = Replace (newText1, 'С', 'с');
Console.WriteLine (newText2);