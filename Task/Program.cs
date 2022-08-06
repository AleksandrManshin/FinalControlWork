void MainMethod()
{
    Console.Write("Введите количество слов которое хотите ввести: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите слово: ");
        array[i] = Console.ReadLine();
    }
}

MainMethod();