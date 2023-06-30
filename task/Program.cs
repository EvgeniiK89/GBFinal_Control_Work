Console.WriteLine("Введите кол-во элементов массива:");
int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] array = new string[sizeArray];
int length = 3;
int count = 0;

for (int i = 0; i < sizeArray; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент массива:");
    string element = Convert.ToString(Console.ReadLine());

    if (element.Length <= length)
    {
        array[count] = element;
        count++;
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i] + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Наш новый массив строк: ");
PrintArray(array);
