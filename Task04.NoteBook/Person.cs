using System.Xml.Linq;

namespace Task04.NoteBook
{
    /// <summary>
    /// Контакт из телефонной книги
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name;
        /// <summary>
        /// Название улицы
        /// </summary>
        public string Street;
        /// <summary>
        /// Номер дома
        /// </summary>
        public string HouseNumber;
        /// <summary>
        /// Номер квартиры
        /// </summary>
        public string FlatNumber;
        /// <summary>
        /// Номер мобильного телефона
        /// </summary>
        public string MobilePhone;
        /// <summary>
        /// Номер домашнего телефона
        /// </summary>
        public string FlatPhone;

        /// <summary>
        /// Создать контакт
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="street">Название улицы</param>
        /// <param name="houseNumber">Номер дома</param>
        /// <param name="flatNumber">Номер квартиры</param>
        /// <param name="mobilePhone">Номер мобильного телефона</param>
        /// <param name="flatPhone">Номер домашнего телефона</param>
        public Person(string name, string street, string houseNumber, string flatNumber, string mobilePhone, string flatPhone)
        {
            Name = name;
            Street = street;
            HouseNumber = houseNumber;
            FlatNumber = flatNumber;
            MobilePhone = mobilePhone;
            FlatPhone = flatPhone;
        }

        /// <summary>
        /// Преобразовать в xml все данные о контакте
        /// </summary>
        /// <returns>
        /// XElement с данными о конатакте
        /// </returns>
        public XElement ToXml()
        {
            return new XElement("Person", new XAttribute("name", Name),
                new XElement("Address",
                    new XElement("Street", Street),
                    new XElement("HouseNumber", HouseNumber),
                    new XElement("FlatNumber", FlatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", MobilePhone),
                    new XElement("FlatPhone", FlatPhone)
                ) 
             );

        }
        /// <summary>
        /// Сохранить в xml-файл данные о контакте
        /// </summary>
        /// <param name="fileName">Название файла, куда будет сохраняться контакт</param>
        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToXml().ToString());
        }
    }
}

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
