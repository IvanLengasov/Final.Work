Console.Write($"Введите массив: ");
var number = Console.ReadLine();
string[] arr = number.Split(',')!.ToArray();
Console.Write($"[{string.Join(" ", arr)}] -> ");
GetArray(arr);
void GetArray(string[] array)
{
    Console.Write("[");
    string[] array2 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
        {
            if (array[i].Length <= 3)
                {
                    Console.Write($"{array[i]} ");
                    Console.Write($",");
                    count++;                   
                }
            }
       Console.Write("]");
 }
