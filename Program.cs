Console.WriteLine("Привет пользователь!");
Console.WriteLine("Выбери что ты хочешь сделать:");
Console.WriteLine("Задача №1: адайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
Console.WriteLine("Задача №2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
Console.WriteLine("Задача №3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
int chose;
chose = Convert.ToInt32(Console.ReadLine());
switch (chose)
{
    case 1:

        Console.Write("Введите количество элементов массива: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] randomArray = new int[a];

void mas(int a)
{
    for (int i = 0; i < a; i++)
{
        randomArray[i] = new Random().Next(99,999);
        Console.Write(randomArray[i] + " ");
}

}

        int kol(int[] randomArray)
{
        int kol = 0;
    for (int i = 0; i < randomArray.Length; i++)
{
        if (randomArray[i] % 2 == 0)
        kol = kol + 1;
}
    return kol;
}

    mas(a);
        Console.Write($"\nКоличество чётных чисел в массиве: {kol(randomArray)}");
        break;
    case 2:
        Console.Write("Введите количество элементов массива: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        int[] randomArray2 = new int[a1];

    void mas1(int a1)
{
    for (int i = 0; i < a1; i++)
    {
        randomArray2[i] = new Random().Next(1,9);
        Console.Write(randomArray2[i] + " ");
    }

}

        int kol1(int[] randomArray2)
{
        int sum = 0;
        int i = 0;
    while (i < randomArray2.Length)
{
    sum = sum + randomArray2[i];
i = i + 2;
}
    return sum;
}

mas1(a1);
Console.Write($"\nCумма нечетных элементов: {kol1(randomArray2)}");
        break;
    case 3:
        var array = new decimal[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите {0} число : ", i+1);
                array[i] = Convert.ToDecimal(Console.ReadLine());
            }
 
            var max = array[0];
            var min = array[0];
            for (int i = 1; i < 10; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            
            Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
        break;    
    default:
        Console.WriteLine("Выберете варианты 1-3");
        break;
}