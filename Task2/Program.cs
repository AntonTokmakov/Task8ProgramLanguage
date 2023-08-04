System.Console.WriteLine("Введите размер двумерного массива через пробел");

int[] sizeMas = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] mas = new int[sizeMas[0], sizeMas[1]];

InputRandMas(mas);
PrintMas(mas);
System.Console.WriteLine($"\nСтрочка {FindMinSumRowMas(mas)} наименьшая по сумме");

int FindMinSumRowMas(int[,] mas){

    int[] sum = new int[mas.GetLength(0)];

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum[i] += mas[i, j];
        }
    }
    
    int minValue = sum[0], minIndex = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < minValue){
            minValue = sum[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

void InputRandMas(int[,] mas){
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMas(int[,] mas){
    System.Console.WriteLine("\nВывод массива\n");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            System.Console.Write(mas[i,j] + "  ");
        }
        System.Console.WriteLine();
    }
}

