//Fazendo referência à biblioteca Random e ao vetor pela variável
Random rnd = new Random();
Double [] preco = new Double [1000];
double soma, maior, menor, media;
soma = 0;

//for: i é igual a 0; i é menor que o range de num (que no caso é 1, [1]); depois soma 1 ao i

/*
for (int i = 0; i < preco.Length; i++)
{
    //irá pritar na tela com o i
    Console.Write("Entrar com o preço " + i + " coletado: ");
    //digitar o valor do preço
    preco [i] = Convert.ToDouble (Console.ReadLine());
}
*/

//for: i é igual a 0; i é menor que o range de num (que no caso é 1, [1]); depois soma 1 ao i
for (int i = 0; i < preco.Length; i++)
{
    while (i < preco.Length)
    {
        //Next double, cria um número de 9 casas decimais
        preco[i] = rnd.NextDouble() * 100;
        Console.WriteLine("Preço " + i + " coletado: R$ " + Math.Round(preco[i], 2));
        i++;
    }
    
}
for (int i = 0; i < preco.Length; i++)
{
    soma = soma + preco[i];
}
Console.WriteLine("A soma dos preços é: R$ " + Math.Round(soma, 2));

//atribuindo valor p/ as variáveis
maior = preco[0]; menor = preco[0];
for (int i = 0; i < preco.Length;)
{
    if (preco[i] > maior)
    {
        maior = preco[i];
        
    }
    else if (preco[i] < menor)
    {  
        menor = preco[i];
    }
    i++;
}
media = soma / preco.Length;

Console.WriteLine("O maior número é: R$ " + Math.Round(maior, 2));
Console.WriteLine("O menor número é: R$ " +Math.Round(menor, 2));
Console.WriteLine("O preço médio é: R$ " +Math.Round(media, 2));
