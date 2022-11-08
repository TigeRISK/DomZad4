// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numX){
    
    int counter = Convert.ToString(numX).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numX - numX % 10;
      result = result + (numX - advance);
      numX = numX / 10;
    }
   return result;
  }
Console.WriteLine($"Сумма цифр в числе = {SumNumber(X)}");