Random rnd = new Random();
int[] senha = new int[4];
int vezes = 4;
int [] jogada = new int[vezes];


#region Gerar a Senha
for (int i = 0; i < senha.Length; i++)
{
    senha[i] = rnd.Next(1,6);
    Console.WriteLine(senha[i]);
}
#endregion

vezes = 4;
while (vezes <= 12)
{
    for (int i = 0; i < jogada.Length; i++)
    {
        Console.WriteLine("Entre com a jogada " + i + ": ");
        jogada[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < senha.Length; i++)
    {
        if (senha[i] == jogada[i])
        {
            Console.WriteLine(" * ");
        }
        else
        {
            Console.Write(" ? ");
        }
    }
    //SequenceEqual irá verificar se todos os números digitados nas tentativas correspondem a senha gerada
    if (senha.SequenceEqual(jogada))
    {
        Console.WriteLine("Parabéns, você ganhou!");
        break;
    }

    //ou 
    //deste modo, fará a mesma função, mas com uma linha maior de código
    if (senha[0] == jogada[0] && senha[1] == jogada[1] && senha[2] == jogada[2] && senha[3] == jogada[3])
    {
        Console.WriteLine("Parabéns, você ganhou!");
        break;
    }

    vezes++;
}


