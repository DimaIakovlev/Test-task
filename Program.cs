Console.Clear();
Console.WriteLine("Введите пять членов массива: ");

string[] baseArray = new string[5];
string[] newArray = new string[5];

for (int i = 0; i < baseArray.Length; i++)
{
    Console.Write($"Array[{i + 1}] = ");
    baseArray[i] = Console.ReadLine();
}

for (int i = 0; i < baseArray.Length; i++)
{
    if (baseArray[i].Length <= 3)
    {
        newArray[i] = baseArray[i];
    }
}

Console.WriteLine("Элементы массива, длинна которых меньше или равна трем: ");

for (int i = 0; i < newArray.Length; i++)
{
    if (newArray[i] == null) ;

    else
    {
        Console.WriteLine($"Array[{i + 1}] = {newArray[i]}");
    }
}