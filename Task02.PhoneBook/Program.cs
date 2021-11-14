var phoneBook = FillPhoneBook();
FindNameFromPhoneBook(phoneBook);


static Dictionary<string, string> FillPhoneBook()
{
    var phoneBook = new Dictionary<string, string>();

    for (; ; )
    {
        Console.WriteLine("Введите номер телефона или нажмите Enter для окончания");
        var phone = Console.ReadLine();
        if (phone == "")
        {
            break;
        }
        Console.WriteLine("Введите ФИО владельца");
        var name = Console.ReadLine();
        phoneBook[phone] = name;
    }
    return phoneBook;
}

static void FindNameFromPhoneBook(Dictionary<string, string> phoneBook)
{
    Console.WriteLine("Введите номер телефона для поиска владельца");
    var findPhone = Console.ReadLine();
    if (phoneBook.TryGetValue(findPhone, out var findName))
    {
        Console.WriteLine($"Владелец:{findName}");
    }
    else
    {
        Console.WriteLine("Владелец данного телефонного номера не найден");
    }
}










//Что нужно сделать
//Пользователю итеративно предлагается вводить в программу номера телефонов и ФИО их владельцев. 
//В процессе ввода информация размещается в Dictionary, где ключом является номер телефона, а 
//значением — ФИО владельца. 
//Таким образом, у одного владельца может быть несколько номеров телефонов. 
//Признаком того, что пользователь закончил вводить номера телефонов, является ввод пустой строки. 
//Далее программа предлагает найти владельца по введенному номеру телефона. Пользователь вводит 
//номер телефона и ему выдаётся ФИО владельца. Если владельца по такому номеру телефона не зарегистрировано, 
//программа выводит на экран соответствующее сообщение.

//Совет
//Для того, чтобы находить значение в Dictionary, нужно использовать TryGetValue.

//Что оценивается
//Программа разделена на логические методы.
//Для хранения элементов записной книжки используется Dictionary.