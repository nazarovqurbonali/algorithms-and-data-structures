using System.Text;

namespace console_app;

public sealed class ExcelSheet
{
    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder result = new();

        while (columnNumber > 0)
        {
            columnNumber--;
            int remainder = columnNumber % 26;
            char letter = (char)('A' + remainder);

            result.Append(letter);
            columnNumber /= 26;
        }

        char[] chars = result.ToString().ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }

    public int TitleToNumber(string columnTitle)
    {
        int result = 0;

        foreach (char symbol in columnTitle)
        {
            int value = symbol - 'A' + 1;

            result = result * 26 + value;
        }

        return result;
    }
}