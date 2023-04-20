Random rnd = new Random();

int[][] Matriz;
int NCol = rnd.Next(0,100);
int NLinhas = rnd.Next(0, 100);

Matriz = new int[NLinhas][];
for (int lin = 0; lin < NLinhas; lin++)
{
    Matriz[lin] = new int[NCol];
    for (int col = 0; col < NCol; col++)
    {
        Matriz[lin][col] = rnd.Next(1, 100);
    }

}
//O usuário entra com um num, e pode saber se o número aparece na matriz e quantas vezes ele aparece
Console.Write("Digite o número que deseja conferir se está na matriz: ");
int num = Convert.ToInt32(Console.ReadLine());
int contador = 0;
int Maior = Matriz[0][0];
for (int lin = 0; lin < NLinhas; lin++)
{
    for (int col = 0; col < NCol; col++)
    {
        Console.Write("[" + Matriz[lin][col] + "]");
        if (Matriz[lin][col] == num)
        {
            contador++;
        }

    }
    Console.WriteLine();
}

Console.WriteLine("MAIOR NÚMERO DA MATRIZ:" + Maior);
Console.WriteLine("O número " + num + " aparece " + contador + " vezes");


