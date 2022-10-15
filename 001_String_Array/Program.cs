Console.WriteLine("Введите количество элементов в массиве");

int length = int.Parse(Console.ReadLine() ?? "0");
string[] massiv = new string[length];
int count = 0;

Console.WriteLine("Введите элементы массива на каждой строчке");
for (int i = 0; i < length; i += 1)
{
    Console.Write($"{i+1} элемент: ");
    massiv[i] = Console.ReadLine() ?? "";
    if (massiv[i].Length <= 3) count += 1;
}
