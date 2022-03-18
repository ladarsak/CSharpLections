void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 5);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

void Find(int[] array, int number)
{
    int compare = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            compare = i;
            break;
        }
    }
    if (compare > -1)
    {
        Console.WriteLine($"The element is present in the array, the position is {compare}");
    }
    else Console.WriteLine("Not found");
}

Console.WriteLine("Please enter a number");
int find = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[10];

FillArray(arr);
Find(arr, find);