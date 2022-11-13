Console.Clear();

string[] array = new string[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine("[" + string.Join(",", array) + "]");

for (int i = 0; i < array.Length - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j].Length < array[minIndex].Length)
        {
            minIndex = j;
        }
    }
    string temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine("Result = : ["+ string.Join(",",array) + "]");