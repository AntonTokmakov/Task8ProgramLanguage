//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

System.Console.WriteLine("Программа по выводy трехмерного массива с индексами");

int[,,] mas = new int[2,2,2];

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            int element = int.Parse(Console.ReadLine());
            /*int elem = (element >= 10 || element <= 99) ? SuchElementMas(mas, element) : -1;
            if (elem != -1) 
                mas[i,j,k] = elem;
            else 
            {
                System.Console.WriteLine("Число существует в массиве или некоректно");
                k--;
            }*/
            if (element >= 10 && element <= 99)
            {
                if (SuchElementMas(mas, element) != -1)
                    mas[i,j,k] = element;
                else
                {
                    System.Console.WriteLine("Число существует в массиве или некорректно");
                    k--;
                }
            }
            else
            {
                System.Console.WriteLine("Введите двухзначное число");
                k--;
            }
        }
    }
}

PrintMas(mas);  

int SuchElementMas(int[,,] mas, int elem)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                if (mas[i,j,k] == elem)
                {
                    return -1;
                }
            }
        }
    }
    return elem;
}

void PrintMas(int[,,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                System.Console.Write($"{mas[i,j,k]}  ({i}, {j}, {k}) ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}
