int Fatorial(int N)
{
    int result = 1;

    for (int i = 1; i <= N; i++)
    {
        result = (result * i);
    }
    return result;
}

Console.WriteLine(Fatorial(3));
Console.WriteLine(Fatorial(4));
Console.WriteLine(Fatorial(5));
Console.WriteLine(Fatorial(9));
Console.WriteLine(Fatorial(10));
