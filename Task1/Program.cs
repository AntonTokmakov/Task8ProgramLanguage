//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

System.Console.WriteLine("Введите размер двумерного массива через пробел");

int[] sizeMas = Console.ReadLine().Trim().Split(" ").Select(x => int.Parse(x)).ToArray();

int[,] mas = new int[sizeMas[0], sizeMas[1]];

InputRandMas(mas);
PrintMas(mas);
DescendingSortMas(mas);

void DescendingSortMas(int[,] mas){

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(1)-1; k++)
            {
                if (mas[i,k] < mas[i,k+1]){
                    int temp;
                    temp = mas[i,k];
                    mas[i,k] = mas[i,k+1];
                    mas[i,k+1] = temp;
                }
            }
        }
    }
    PrintMas(mas);
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

