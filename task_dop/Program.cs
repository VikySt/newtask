// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
// 1	1 7 9 0 -> 7
// 2	1 2 3 4 5 6 7 0 8 9 10 -> 6

Console.Clear();
int n = Convert.ToInt32(ReadLine());
int firstMax = n, secondMax = -1;

while (n != 0)
{
    int n = Convert.ToInt32(ReadLine());
    if (n > firstMax)
    {
        secondMax = firstMax;
        firstMax = n;
    }
    else if (n > secondMax)
         secondMax = n;
}
Console.WriteLine(secondMax);