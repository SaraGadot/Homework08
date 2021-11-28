using Task04.NoteBook;

var person = InputPerson();
person.Save("person.xml");

/// <summary>
/// Ввести данные конаткта с клавиатуры
/// </summary>
static Person InputPerson()
{
    Console.WriteLine("Введите ФИО:");
    var name = Console.ReadLine();
    Console.WriteLine("Введите название улицы:");
    var street = Console.ReadLine();
    Console.WriteLine("Введите номер дома:");
    var houseNumber = Console.ReadLine();
    Console.WriteLine("Введите номер квартиры:");
    var flatNumber = Console.ReadLine();
    Console.WriteLine("Введите номер мобильного телефона:");
    var mobilePhone = Console.ReadLine();
    Console.WriteLine("Введите номер домашнего телефона:");
    var flatPhone = Console.ReadLine();

    return new Person(name, street, houseNumber, flatNumber, mobilePhone, flatPhone);


}











//Задание 4.Записная книжка


//Что нужно сделать
//Программа спрашивает у пользователя данные о контакте:

//ФИО
//Улица
//Номер дома
//Номер квартиры
//Мобильный телефон
//Домашний телефон


//С помощью XElement создайте xml файл, в котором есть введенная информация. 
//XML файл должен содержать следующую структуру:

//<Person name=”ФИО человека”>
//    <Address>
//        <Street>Название улицы</Street>
//        <HouseNumber>Номер дома</HouseNumber>
//        <FlatNumber>Номер квартиры</FlatNumber>
//    </Address>
//    <Phones>
//        <MobilePhone>89999999999999</MobilePhone>
//        <FlatPhone>123-45-67<FlatPhone>
//    </Phones>
//</Person>


//Советы и рекомендации
//Заполняйте XElement в ходе заполнения данных. Изучите возможности XElement в документации Microsoft.



//Что оценивается
//Программа создаёт Xml файл, содержащий все данные о контакте.
