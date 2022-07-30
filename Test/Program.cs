string [] CreateArray(string path)
{
    string[] Text = File.ReadAllText(path)
    .Split(new char[] { ' ', ',', ':', ';', '.', '!' }
    , StringSplitOptions.RemoveEmptyEntries);
    return Text;
}

string MainTask(string []array)
{
    int count = 0;
    int index = 0;
    string[] TempText = new string[0];

    while (count < array.Length)
    {
        if (array[count].Length <= 3)
        {
            Array.Resize(ref TempText, TempText.Length + 1);
            TempText[index] = array[count];
            index++;
        }
        count++;
    }
string FinalText = String.Join(",", TempText);
return FinalText;
}

void WriteArrayInFile(string FinalText)
{
    File.WriteAllText(@"C:\Users\ksenya\Desktop\FinalTestWork\Test\output.txt", FinalText);
}

string path = @"C:\Users\ksenya\Desktop\FinalTestWork\Test\input.txt";


WriteArrayInFile(MainTask(CreateArray(path)));
