namespace Task03.Repeating
{
    internal class Repeats
    {
        protected HashSet<int> _repeats = new HashSet<int>();
        public bool TryAdd(int number)
        {
            if (_repeats.Contains(number))
                return false;
            _repeats.Add(number);
            return true;
        }
    }
}
