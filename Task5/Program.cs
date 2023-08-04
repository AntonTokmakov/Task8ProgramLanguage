System.Console.WriteLine("Спиральный заполнитель массива");

int[,] spiral = new int[4, 4];

SpiralMas(ref spiral);
PrintMas(spiral);

void SpiralMas(ref int[,] spiral){
    int a = 1;
    int minR = 0, maxR = 3, minC = 0, maxC = 3;

    while (a <= 16)
    {
        for (int i = minC; i <= maxC; i++)
        {
            spiral[minR, i] = a;
            a++;
        }
        minR++;

        for (int i = minR; i <= maxR; i++)
        {
            spiral[i, maxC] = a;
            a++;
        }
        maxC--;

        for (int i = maxC; i >= minC; i--)
        {
            spiral[maxR, i] = a;
            a++;
        }
        maxR--;

        for (int i = maxR; i >= minR; i--)
        {
            spiral[i, minC] = a;
            a++;
        }
        minC++;
    }
}

void PrintMas(int[,] mas){
    System.Console.WriteLine("Вывод массива");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            System.Console.Write(mas[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}