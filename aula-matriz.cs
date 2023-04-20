int[][] Matriz;

Matriz=new int[3][];
Matriz[0] = new int[3];
Matriz[1] = new int[3];
Matriz[2] = new int[3];

//cada célula é 0 
//irá alimentar as colunas de cada linha
for (int lin=0; lin < 3; lin++)
{
    for(int col = 0;col < 3; col++)
    {
        Matriz[lin][col] = 3*lin+col;
    }
}

//irá imprimir cada linha com as respectivas colunas 
for (int lin = 0; lin < 3; lin++)
{
    for (int col = 0; col < 3; col++) {

        Console.Write("[" + Matriz[lin][col] + "]");
    }
    Console.WriteLine();
}
