int[,] mat = {  { 3, 2, 1, 5, 6 },
                { 4, 5, 6, 8, 10 },
                { 9, 8, 10, 8, 6 } };

int[,] matrizInvertida = new int[3, 5];


void InverteValores(int[,] mat, int[,] matrizInvertida)
{
    int tamLinha = mat.GetLength(0);
    int tamColuna = mat.GetLength(1);

    for (int linha = 0; linha < tamLinha; linha++)
        for (int coluna = 0; coluna < tamColuna; coluna++)
            matrizInvertida[linha, coluna] = mat[(tamLinha-1) - linha, (tamColuna - 1) - coluna];
}

InverteValores(mat, matrizInvertida);

for (int linha = 0; linha < mat.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < (mat.GetLength(1)); coluna++)
        Console.Write("[" + matrizInvertida[linha,coluna] + "] ");
    Console.WriteLine();
}
