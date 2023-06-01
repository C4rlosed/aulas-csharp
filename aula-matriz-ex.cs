Random rnd = new Random();

int[][] Matriz;
int NCol = rnd.Next(0, 100);
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

//Verificar qual o maior número da matriz
int Maior = Matriz[0][0];
//Enquanto linhas for menor que N de Linhas, lin++
for(int lin = 0; lin < NLinhas; lin++)
{
    //Enquanto colunas for menor que N de Colunas, col++
    for (int col = 0;col < NCol; col++)
    {
        //Se Maior for menor que os números de linhas e os números de colunas
        if(Maior < Matriz[lin][col])
        {
            //Maior é igual a quantidade de lin e col na Matriz
            Maior = Matriz[lin][col];
        }
    }
}


Console.WriteLine("MAIOR NÚMERO DA MATRIZ:" + Maior);
Console.WriteLine("O número " + num + " aparece " + contador + " vezes");


