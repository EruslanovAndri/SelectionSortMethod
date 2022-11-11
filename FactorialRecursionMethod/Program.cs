Console.Clear();
Console.Write("Put the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Factorial(int n)
{
    if(n == 1) return 1;
    else
    {
        return n * Factorial(n-1);
    }
}

Console.Write(Factorial(n));
