//Сложение 2 матриц

System.Console.WriteLine("Введите размер матриц через пробел");

int[] sizeMas = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] matrix1 = new int[sizeMas[0], sizeMas[1]];
int[,] matrix2 = new int[sizeMas[0], sizeMas[1]];

InputRandMas(matrix1);
InputRandMas(matrix2);
PrintMas(matrix1, matrix2);
PrintMas(SumMatrix(matrix1, matrix2));


int[,] SumMatrix(int[,] mas1, int[,] mas2){

    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas1.GetLength(1); j++)
        {
            mas1[i,j] *= mas2[i,j];
        }
    }
    return mas1;
}

void InputRandMas(int[,] mas){
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(0, 8);
        }
    }
}

void PrintMas(int[,] mas1, int[,] mas2 = null){
    System.Console.WriteLine("\nВывод матриц\n");
    for (int i = 0; i < mas1.GetLength(0); i++)
    {
        for (int j = 0; j < mas1.GetLength(1); j++)
        {
            System.Console.Write(mas1[i,j] + "  ");
        }
        if (mas2 != null)
        {
            System.Console.Write(" |  ");
            for (int j = 0; j < mas2.GetLength(1); j++)
            {
                System.Console.Write(mas2[i,j] + "  ");
            }
        }
        System.Console.WriteLine();
    }
}

