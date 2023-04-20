int maior(int x,int y)
{
    int result = x;
    
    if (y > result) { result= y; }
    return result;

}

int r;

r = maior(10,15);
Console.WriteLine(r);
Console.WriteLine(maior(100,150));
Console.WriteLine(maior(150, 100));
Console.WriteLine(maior(10,maior(3,7)));
