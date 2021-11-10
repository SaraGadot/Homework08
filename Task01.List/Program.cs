var numbers = GenerateNumbers();
DisplayNumbers(numbers);
DeleteNumbers(numbers);
Console.WriteLine("После удаления:");
DisplayNumbers(numbers);

static void DisplayNumbers(List<int> numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}
static List<int> GenerateNumbers()
{
    var numbers = new List<int>();
    var random = new Random();
    for (var i = 0; i < 100; i++)
    {
        numbers.Add(random.Next(100));
    }
    return numbers;
}
static void DeleteNumbers(List<int> numbers)
{
    numbers.RemoveAll(number => 25 < number && number < 50);
}










//Что нужно сделать
//Создайте лист целых чисел. 
//Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
//Выведите коллекцию чисел на экран. 
//Удалите из листа числа, которые больше 25, но меньше 50. 
//Снова выведите числа на экран. 


//Рекомендация
//Сделайте отдельные методы для заполнения, удаления и вывода на экран.



//Что оценивается
//В программе используется три отдельных метода. 
//В качестве хранилища данных используется List.