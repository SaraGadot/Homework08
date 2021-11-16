var repeats = new HashSet<int>();
for (; ; )
{
    Console.WriteLine("Введите число (или Enter для выхода):");
    var number = ReadInt();
    if(number == null)
    {
        break;
    }
    if (repeats.Contains(number.Value))
    {
        Console.WriteLine("Такое число уже было введено ранее");
    }
    else
    {
        repeats.Add(number.Value);
        Console.WriteLine("Число успешно сохранено");
    }

}

static int? ReadInt()
{
    for (; ; )
    {
        var numberText = Console.ReadLine();
        if (numberText == "")
        {
            return null;
        }
        if (int.TryParse(numberText, out var number))
        {
            return number;
        }
        Console.WriteLine("Неверный ввод, введите, пожалуйста, число:");
    }
}











//Задание 3.Проверка повторов


//Что нужно сделать
//Пользователь вводит число. Число сохраняется в HashSet коллекцию.
//Если такое число уже присутствует в коллекции, то пользователю на экран выводится сообщение,
//что число уже вводилось ранее. Если числа нет, то появляется сообщение о том, что число успешно сохранено. 



//Советы и рекомендации
//Для добавление числа в HashSet используйте метод Add. 



//Что оценивается
//В программе в качестве коллекции используется HashSet.
