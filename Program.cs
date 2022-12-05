Console.Clear();
Console.Write("Введите члены массива через пробел: ");
var temp = Console.ReadLine().Split(' ').Select(token=> int.Parse(token));
string[] baseArray = GetArrayFromString(temp);

string[] GetArrayFromString(string stringArray)
{
    int[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        res[i] = string.Parse(numbers[i]);
    }
    return res;
}

