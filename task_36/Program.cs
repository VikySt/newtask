// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-9, 10);
}

int Summa(int[] array)
{
   int summaP = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (i % 2 == 1)
         summaP = summaP + array[i];
   }
   return summaP;
}

Console.Clear();
int[] array = new int[6];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Summa(array)}");