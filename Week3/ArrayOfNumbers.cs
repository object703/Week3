namespace Week3
{
    internal class ArrayOfNumbers
    {
        int[] _numbers;

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
    }
}
