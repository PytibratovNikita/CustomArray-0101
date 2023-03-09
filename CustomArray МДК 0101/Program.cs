using CustomArray;

var array = new CustomArray<int>();

array.Add(1);
array.Add(2);
array.Add(3);
array.Add(4);
array.Add(5);

Console.WriteLine("Инициализация массива :");
array.Print();

array.Delete(2);

Console.WriteLine("Массив после удаления индекса 3 :");
array.Print();

int first = array.FindFirst(x => x % 3== 0);
Console.WriteLine($"Первое чётное число: {first}");

array.Swap(1, 2);

Console.WriteLine("Массив после замены индексов 1 и 2 :");
array.Print();

Console.ReadKey();