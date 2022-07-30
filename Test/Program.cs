string newpath = @"C:\Users\ksenya\Desktop\FinalTestWork\Test\input.txt";

string [] Text = File.ReadAllText(newpath)
.Split(new char[]{' ', ',', ':', ';','.','!'}
, StringSplitOptions.RemoveEmptyEntries); 
foreach (string item in Text)
{
    Console.WriteLine(item);
}
