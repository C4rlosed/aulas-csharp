Random rnd= new Random();
Double[] Preco = new Double[1000];
int i;
double soma, maior, menor, medio;

/*
Preco[0] = rnd.NextDouble() * 100;
Preco[1] = rnd.NextDouble() * 100;
Preco[2] = rnd.NextDouble() * 100;
Preco[3] = rnd.NextDouble() * 100;
Preco[4] = rnd.NextDouble() * 100;
*/

i = 0;
while (i < Preco.Length)
{
    //Next double, cria um número de 9 casas decimais
    Preco[i] = rnd.NextDouble() * 1000;
    i++;
}
i = 0;
soma = 0;
while (i < Preco.Length)
{
    soma=soma + Preco[i];
    Console.WriteLine("R$ " + Math.Round(Preco[i], 2));
    i++; //Equivale a i=i+1
}

maior = Preco[0]; menor = Preco[0];
i = 1;
while (i < Preco.Length)
{
    if (Preco[i] > maior)
    {
        maior = Preco[i];
    }
    if (Preco[i] < menor)
    {
        menor = Preco[i];
    }
    i++;
}
medio = soma / Preco.Length;

Console.WriteLine("A soma dos preços é igual a R$ " + Math.Round(soma, 2));
Console.WriteLine("O maior preço é R$ " + Math.Round(maior, 2));
Console.WriteLine("O menor preço é R$ " + Math.Round(menor, 2));
Console.WriteLine("A média de preço é R$ " + Math.Round(medio, 2));
