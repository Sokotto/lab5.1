Console.Write("Введите строку: ");
string input = Console.ReadLine();
string transformedString = TransformString(input);
Console.WriteLine("Преобразованная строка: " + transformedString);
static string TransformString(string input)
{
    char[] result = new char[input.Length * 2];
    int index = 0;

    foreach (char c in input)
    {
        if (c != '*')
        {
            result[index++] = c;
            result[index++] = c;
        }
    }
    return new string(result, 0, index);
}