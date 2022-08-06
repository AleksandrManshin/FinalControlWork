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

    Console.WriteLine("Вывод слов которые имеют количество букв равное 3 и меньше");
    Checking(array);
}


void Checking(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write(array[i] + "\t");
    }
}

MainMethod();