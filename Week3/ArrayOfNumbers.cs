namespace Week3
{
    internal class ArrayOfNumbers
    {
        private int[] _numbers;

        // Create array of specified length with each value 0
        public ArrayOfNumbers(int length)
        {
            // https://stackoverflow.com/a/76573590
            _numbers = Enumerable.Repeat(0, length).ToArray();
        }

        // Create array with specified values
        public ArrayOfNumbers(int[] numbers)
        {
            // https://learn.microsoft.com/en-us/dotnet/api/system.array.clone?view=net-8.0
            _numbers = (int[])numbers.Clone();
        }

        public int[] Numbers { get => _numbers; set => _numbers = value; }
        public void updateValue(int index, int value)
        {
            _numbers[index] = value;
        }
    }
}
