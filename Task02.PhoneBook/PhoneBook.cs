namespace Task02.PhoneBook
{
    internal class PhoneBook
    {
        protected Dictionary<string, Person> personsByPhoneIndex = new Dictionary<string, Person>();

        public void Add(Person person)
        {
            personsByPhoneIndex[person.Phone] = person;
        }

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
