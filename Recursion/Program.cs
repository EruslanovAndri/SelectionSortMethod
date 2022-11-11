Console.Clear();
Console.Write("Put the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
RecursionCountDown(n);
int RecursionCountDown(int n)
{
    if (n == 0) return n;
    {
        Console.WriteLine($"{n}");
        RecursionCountDown(n - 1);
    }
    return n;
}
