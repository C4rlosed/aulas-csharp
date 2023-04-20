Random rnd= new Random();

int[][] Matriz;
//int NCol = rnd.Next(0,1000);
//int NLinhas = rnd.Next(0, 1000);
int NCol;

Matriz = new int[rnd.Next(0,100)][];
for (int lin = 0; lin < Matriz.Length; lin++)
{
    NCol = rnd.Next(0,100);
    Matriz[lin] = new int[NCol];
    for (int col = 0; col < Matriz[lin].Length; col++)
    {
        Matriz[lin][col] = rnd.Next(1, 100);
    }

}

int Maior = Matriz[0][0];
for (int lin = 0; lin < Matriz.Length; lin++)
{
    for (int col = 0; col < Matriz[lin].Length; col++)
    {
        Console.Write("[" + Matriz[lin][col] + "]");
        if (Matriz[lin][col] >Maior) { Maior = Matriz[lin][col]; }
    }
    Console.WriteLine();
}
Console.WriteLine("MAIOR NÚMERO DA MATRIZ:" + Maior);
