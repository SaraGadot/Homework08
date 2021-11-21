using System.Xml.Linq;

namespace Task04.NoteBook
{
    internal class Person
    {
        public string Name;
        public string Street;
        public string HouseNumber;
        public string FlatNumber;
        public string MobilePhone;
        public string FlatPhone;

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
