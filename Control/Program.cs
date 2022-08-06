/* **Задача**: Написать программу, которая из имеющегося массива
строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
**Примеры**:
[hello,2,world,:-)] -> ["2", ":-)"]
[1234,1567,-2,computer science] -> ["-2"]
[Russia,Denmark,Kazan] -> [] */

System.Console.WriteLine("Введите количество элементов массива: \t");

string[] CreateAndShowArr(int size)
{
    string[] str = new string[size];
    for (int i = 0; i < str.Length; i++)
    {
        System.Console.WriteLine($"Введите элемент №{i + 1}");
        str[i] = Console.ReadLine()!;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write("\nИзначальный массив: [");
    foreach (var item in str)
    {
        Console.Write(item + ", ");
    }
    System.Console.Write("\b \b]");
    Console.ForegroundColor = ConsoleColor.White;
    return str;
}
string[] str = CreateAndShowArr(int.Parse(Console.ReadLine()!));

string[] SelectThreeDigitValues (string[] str)
{
    string[] selected = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        selected[i] = str[i].Length <= 3 ? str[i] : null;
    }
    selected = selected.Where(x => x != null).ToArray();
    return selected;
}
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine($"\nОтсортированный массив: [{string.Join(", ", SelectThreeDigitValues(str))}]");
Console.ForegroundColor = ConsoleColor.White;   