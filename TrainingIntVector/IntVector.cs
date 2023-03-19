using System.Collections;

namespace TrainingIntVector
{
    public class IntVector
    {
        int length = 0;
        int capacity;
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
        }

        public IntVector(int[] arr)
        {
            length = arr.Length;
            int result = (int)Math.Ceiling((double)length / 4);
            switch (length)
            {
                case <= 4: capacity = 4; break;
                case > 4: capacity = result*_defaultCapacity; break;
            }
            _arr = new int[capacity];

            for(int i = 0; i < length; i++)
            {
                _arr[i] = arr[i];
            }
        }

        public void AddNewElement(int num)
        {
            if (length == capacity)
            {
                CopyOldAndCrateNewArray();
                _arr[length] = num;
                length++;
            }
            else if (length < capacity)
            {
                _arr[length] = num;
                length++;
            }
        }

        public int ReturnCapacity()
        {
            return capacity;
        }

        public int ReturnLength()
        {
            return length;
        }

        // с названием мог переборщить :)
        public void CopyOldAndCrateNewArray()
        {
            int[] tempArr = _arr;
            capacity *= 2;
            _arr = new int[capacity];
            int i = 0;
            foreach (int valueArr in tempArr)
            {
                _arr[i] = valueArr;
                i++;
            }
        }

        public void RemoveAt(int index)
        {
            int[] tempArr = new int[capacity];
            int f = 0;
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (_arr[i] == index)
                {
                    continue;
                }
                else
                {
                    tempArr[f] = _arr[i];
                    f++;
                }
            }
            length--;
            _arr = tempArr;
        }

        public void RemoveAllThisInstances(int value)
        {
            int[] tempArr = new int[capacity];
            int i = 0;
            foreach (int valueArr in _arr)
            {
                if (valueArr == value)
                {
                    length--;
                    continue;
                }

                tempArr[i] = valueArr;
                i++;
            }
            _arr = tempArr;
        }

        public void Clear()
        {
            _arr = new int[4];
            length = 0;
            capacity = 4;
        }
    }
}
