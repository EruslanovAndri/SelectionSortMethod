// Buuble sort

Console.Clear();
Console.WriteLine("Put the number of array elements:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Put element one by one: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Usorted array = [" + string.Join(",", array) + "]");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - i - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;

        }
    }
    Console.WriteLine("Iteration numbers = " + i + " Sorted array = [" + string.Join(",", array) + "]");
}



