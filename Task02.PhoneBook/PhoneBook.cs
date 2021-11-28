namespace Task02.PhoneBook
{
    /// <summary>
    /// Записная книжка
    /// </summary>
    internal class PhoneBook
    {
        protected Dictionary<string, Person> personsByPhoneIndex = new Dictionary<string, Person>();

        /// <summary>
        /// Добавить владельца телефона в записную книжку
        /// </summary>
        /// <param name="person">Владелец телефона</param>
        public void Add(Person person)
        {
            personsByPhoneIndex[person.Phone] = person;
        }

        /// <summary>
        /// Найти владельца телефона по номеру телефона
        /// </summary>
        /// <param name="phone">Номер телефона для поиска</param>
        /// <returns>Найденный владелец телефона или null, если не найдено</returns>
        public Person FindByPhone(string phone)
        {
            if (personsByPhoneIndex.TryGetValue(phone, out var person))
            {
                return person;
            }
            else
            {
                return null;
            }
        }
    }
}
