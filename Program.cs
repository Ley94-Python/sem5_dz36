// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int size)
{

int[] arr = new int[size];

for(int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(1, 10);
}
return arr;
}

Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(num);
Console.WriteLine(string.Join(", ", array));
uint oddNumbersCount = 0; // счетчик для нечетных чисел в массиве
int sum = 0;
for(int i = 0; i < array.Length; i++)

{
    if (array[i] % 2 == 1)
    {
        oddNumbersCount++;
        sum = sum + array[i];
    }

}

Console.WriteLine($"Сумма  нечетных чисел: " + sum);