//Programa que coleta o nome do produto, três preços e calcula o preço médio. Logo após, mostra na tela qual o maior preço.

String NomeProduto;
Double Preco1, Preco2, Preco3, PrecoMedio, MPreco, FPreco;
Console.Write("Digite o nome do produto: ");
NomeProduto = Console.ReadLine();
Console.Write("Digite o primeiro preço: ");
Preco1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo preço: ");
Preco2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o terceiro preço: ");
Preco3 = Convert.ToDouble(Console.ReadLine());

PrecoMedio = (Preco1 + Preco2 + Preco3) / 3;
PrecoMedio = Math.Round(PrecoMedio,2);
Console.WriteLine("Produto: " + NomeProduto);
Console.WriteLine("Preço Médio = " + PrecoMedio);

MPreco = Math.Max(Preco1, Preco2);
FPreco = Math.Max(MPreco, Preco2);
Console.WriteLine("O preço maior é: " + FPreco);

//OU

Console.WriteLine("O maior preço inserido foi: " +Math.Max(Preco1, Math.Max(Preco2, Preco3)));

//OU desta maneira:

MPreco = 1;
FPreco = Preco1;
if (Preco2 > FPreco)
{

    MPreco = 2;
    FPreco = Preco2;
}
else if (Preco3 > FPreco)
{

    MPreco = 3;
    FPreco = Preco3;
}
else if (Preco1 == Preco2 || Preco2 == Preco3)
{

    Console.WriteLine("Todos os preços são iguais!");
    return;
}

Console.WriteLine("O preço " + MPreco + " de valor " + FPreco + " é o Maior preço coletado!");
