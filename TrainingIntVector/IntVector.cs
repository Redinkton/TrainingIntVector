namespace TrainingIntVector
{
    public class IntVector
    {
        private int _length;
        private int _capacity;
        private const int _defaultCapacity = 4;
        private int[] _arr;

        public int this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }

        public IntVector()
        {
            _arr = new int[_defaultCapacity];
            _capacity = _defaultCapacity;
        }

        public IntVector(int[] arr)
        {
            _length = arr.Length;
            int result = (int)Math.Ceiling((double)_length / 4);
            switch (_length)
            {
                case <= 4: _capacity = _defaultCapacity; break;
                case > 4: _capacity = result * _defaultCapacity; break;
            }
            _arr = new int[_capacity];

            for(int i = 0; i < _length; i++)
            {
                _arr[i] = arr[i];
            }
        }

        public void AddNewElement(int num)
        {
            if (_length == _capacity)
            {
                CopyArray();
                _arr[_length] = num;
                _length++;
            }
            else if (_length < _capacity)
            {
                _arr[_length] = num;
                _length++;
            }
            else
            {
                throw new Exception("ERROR");
            }
        }

        public int ReturnCapacity()
        {
            return _capacity;
        }

        public int ReturnLength()
        {
            return _length;
        }

        public void CopyArray()
        {
            _capacity *= 2;
            _arr = ExtendArray(_arr, _capacity);
        }

        private int[] ExtendArray(int[] oldArray, int newCapacity)
        {
            int[] newArray = new int[_capacity];
            int i = 0;

            foreach (int valueArr in oldArray)
            {
                newArray[i] = valueArr;
                i++;
            }
            return newArray;
        }

        public void RemoveAt(int index)
        {
            int[] tempArr = new int[_capacity];
            int f = 0;
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (i== index)
                {
                    continue;
                }
                else
                {
                    tempArr[f] = _arr[i];
                    f++;
                }
            }
            _length--;
            _arr = tempArr;
        }

        public void RemoveAllThisInstances(int value)
        {
            int[] tempArr = new int[_capacity];
            int i = 0;
            foreach (int valueArr in _arr)
            {
                if (valueArr == value)
                {
                    _length--;
                    continue;
                }

                tempArr[i] = valueArr;
                i++;
            }
            _arr = tempArr;
        }

        public void Clear()
        {
            _arr = new int[_defaultCapacity];
            _length = 0;
            _capacity = _defaultCapacity;
        }

        public void AddAtIndex(int index, int value)
        {
            _arr[index] = value;
        }
    }
}
