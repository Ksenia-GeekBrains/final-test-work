string [] CreateArray(string path)
{
    string[] Text = File.ReadAllText(path)
    .Split(new char[] { ' ', ',', ':', ';', '.', '!' }
    , StringSplitOptions.RemoveEmptyEntries);
    return Text;
}

string MainTask(string []InputArray)
{
    int count = 0;
    int index = 0;
    string[] InputText = new string[0];

    while (count < InputArray.Length)
    {
        if (InputArray[count].Length <= 3)
        {
            Array.Resize(ref InputText, InputText.Length + 1);
            InputText[index] = InputArray[count];
            index++;
        }
        count++;
    }
string FinalText = String.Join(",", InputText);
return FinalText;
}

void WriteArrayInFile(string FinalText)
{
    File.WriteAllText(@"C:\Users\ksenya\Desktop\FinalTestWork\Test\output.txt", FinalText);
}

string path = @"C:\Users\ksenya\Desktop\FinalTestWork\Test\input.txt";


WriteArrayInFile(MainTask(CreateArray(path)));
