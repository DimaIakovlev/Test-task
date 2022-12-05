Console.Clear();
Console.WriteLine("Введите пять членов массива: ");

string[] baseArray = new string[5];
string[] newArray = new string[5];

for (int i = 0; i < baseArray.Length; i++)
{
    Console.Write($"Array[{i}] = ");
    baseArray[i] = Console.ReadLine();
}
for (int i = 0; i < baseArray.Length; i++)
{
    if (baseArray[i].Length <= 3)
    {
        newArray[i] = baseArray[i];
    }

}