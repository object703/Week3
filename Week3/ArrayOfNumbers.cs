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

        public void SetValue(int index, int value)
        {
            _numbers[index] = value;
        }

        public bool IsEqual(int x, int y)
        {
            if (x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GCD(int first, int second)
        {
            int x = _numbers[first];
            int y = _numbers[second];

            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            return x;
        }

        public int GetMax()
        {
            return _numbers.Max();
        }

        public int GetCount()
        {
            return _numbers.Length;
        }

        public int GetSum()
        {
            int sum = 0;

            foreach (int x in _numbers)
            {
                sum += x;
            }

            return sum;
        }

        public double GetAverage()
        {
            return GetSum() / GetCount();
        }

        public override string ToString()
        {
            string output = "";

            foreach (var item in _numbers)
            {
                output += item + ", ";
            }

            return output;
        }

        public void Add(int constant)
        {
            for (int i =0; i < _numbers.Length; ++i)
            {
                _numbers[i] += constant;
            }
        }


        public void Multiply(int multiplier)
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i] *= multiplier;
            }
        }
    }
}
