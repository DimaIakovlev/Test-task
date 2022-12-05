Console.Clear();
Console.Write("Введите члены массива через запятую");
string temp = Console.ReadLine();
string[] arrayA = temp.Split(new Char[] { ' ' });
string[arrayA.GetLength()] arrayB = "";
for (int i = 0; i < arrayA.GetLength(); i++)
{
    if (arrayA.GetLength(i) == 3)
    {
        arrayB[i] = arrayA[i];
    }
}

for (int i = 0; i < arrayB.GetLength(); i++)
{
    Console.Write(arrayB[i]);
}