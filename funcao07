Console.WriteLine(Fatorial(5));
static int Fatorial(int N)
{
    int fat = 1;

    if(N > 1)
    {
        fat = N * Fatorial(N - 1);
    }
    else
    {
        fat = 1;
    }
    return fat;
}

Double NI = 7.4;
Double PI = 7.3;
Double PO = 6;

Console.WriteLine("NI: "+ NI + " PI: "+ PI + " PO: "+ PO);
Double media = Media(NI, PI, PO);
ImprimirStatus(media);

Double Media (Double NI, Double PI, Double PO)
{
    Double media = NI * 0.2 + PI * 0.3 + PO * 0.5;
    return media;
}
void ImprimirStatus(Double media)
{
    if(media >= 6)
    {
        Console.WriteLine("Aprovado!");
    }
    else
    {
        Console.WriteLine("Reprovado!");
    }
}
