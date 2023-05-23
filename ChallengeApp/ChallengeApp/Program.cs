int number = 2137;
string numberInString=number.ToString();
char[] letters = numberInString.ToArray();

for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char letter in letters) 
    {
        if (int.Parse(letter.ToString()) == i) 
        {
            counter++;
        }
    }
    Console.WriteLine(i + "=>" + counter);
}