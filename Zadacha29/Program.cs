// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] getNewArray(int lenghtArr)
{
    int[] array = new int[lenghtArr];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
foreach (int item1 in getNewArray(1))
foreach (int item2 in getNewArray(1))
foreach (int item3 in getNewArray(1))
foreach (int item4 in getNewArray(1))
foreach (int item5 in getNewArray(1))
foreach (int item6 in getNewArray(1))
foreach (int item7 in getNewArray(1))
foreach (int item8 in getNewArray(1))
{
    Console.Write($"[{item1},{item2},{item3},{item4},{item5},{item6},{item7},{item8}]");
}