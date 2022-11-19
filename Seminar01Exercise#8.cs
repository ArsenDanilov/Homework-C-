// Задача № 8. Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N

int number = 5; // 8
int index = 1;
while (index <= number)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}