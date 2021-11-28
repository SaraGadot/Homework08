namespace Task02.PhoneBook
{
    /// <summary>
    /// Владелец телефона
    /// </summary>
    internal class Person
    {
        /// <summary>
        ///  ФИО владельца телефона
        /// </summary>
        public string Name;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone;

        /// <summary>
        /// Создать владельца телефона
        /// </summary>
        /// <param name="namе">ФИО владельца телефона</param>
        /// <param name="phone">Номер телефона</param>
        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
    }
}
