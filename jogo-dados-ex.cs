Random rnd = new Random();
//Variáveis
double Dado1, Dado2, Soma, count, win, lose, saldo, rvezes;
string rodada;
saldo = 0;
count = 1;
rvezes = 1;
//Definindo um valor 0 para as vars win e lose
win = 0;
lose = 0;
Console.WriteLine("Qual o valor de saldo gostaria de depositar para jogar?");
saldo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("O seu saldo é de: R$ " +saldo);

while (count <= rvezes)
{
    //números aleatórios de 1 a 7 (mas contando até o 6° num)
    Dado1 = rnd.Next(1, 7);
    Dado2 = rnd.Next(1, 7);
    
    Soma = Dado1 + Dado2;
    Console.WriteLine("Dado 1: " + Dado1);
    Console.WriteLine("Dado 2: " + Dado2);
    #region Sorteio
    if (Dado1 == Dado2)
    {
        Console.WriteLine("Parabéns, você ganhou!!!");
        Console.WriteLine("Os dados são iguais!!");
        //Ganhou, soma 1 na var win 
        win++;
        saldo += 10;
        Console.WriteLine("O seu saldo agora é de: R$ " + saldo);

    }
    else if (Soma == 7 || Soma == 11)
    {
        Console.WriteLine("Parabéns, você ganhou!!!");
        Console.WriteLine("A soma dos dados é igual a " + Soma);
        //Ganhou, soma 1 na var win 
        win++;
        saldo += 10;
        Console.WriteLine("O seu saldo agora é de: R$ " + saldo);
    }
    else
    {
        Console.WriteLine("Que pena, não foi desta vez!!!");
        //Perdeu, soma 1 na var lose
        lose++;
        saldo -= 10;
        Console.WriteLine("O seu saldo agora é de: R$ " + saldo);
    }
    Console.WriteLine("Você ganhou " +win+ " vezes!");
    Console.WriteLine("Você perdeu " +lose+ " vezes!");
    Console.WriteLine("Você gostaria de jogar mais uma vez? S ou N");
    //var rodada irá receber a resposta se Sim ou se Não
    rodada = Console.ReadLine();
    //se Sim (S ou s)
    if(rodada == "S" || rodada == "s")
    {
        //irá somar mais um no número de rodadas, e o laço acontecerá novamente
        rvezes++;
        count++;
    }
    //se Não (N ou n)
    else if(rodada == "N" || rodada == "n")
    {
        //irá finalizar a rodada
        count++;
    }
    #endregion Sorteio
}
