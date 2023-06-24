
int number = 564888;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] outcome = new int[10];
char[] meter = { '0', '1', '2', '3', '4', '5', '6' , '7', '8', '9' };

foreach (char number2 in numberInString)
{
    for(int i = 0; i < meter.Length; i++)
    {
        if (meter[i] == number2)
        {
            outcome[i]++;
            
        }

    }
}
for (int i = 0; i < outcome.Length; i ++)
{
    Console.WriteLine(meter[i] + " => " + outcome[i]);
}
