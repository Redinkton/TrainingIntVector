namespace TrainingIntVector
{
    public class IntVector
    {
        int length = 0;
        int capacity = 4;
        private int[] arr;

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        public IntVector()
        {
            arr = new int[4];
        }

        public void AddNewElement(int num)
        {
            if (length == capacity)
            {
                CopyOldAndCrateNewArray();
                arr[length] = num;
                length++;
            }
            else if (length < capacity)
            {
                arr[length] = num;
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

        public void AddToEnd(int num)
        {
            if (length < capacity)
            {
                arr[arr.Length - 1] = num;
            }
            else if (length > capacity)
            {
                CopyOldAndCrateNewArray();
                arr[arr.Length - 1] = num;
            }
            else if (length == capacity)
            {
                CopyOldAndCrateNewArray();
                arr[length] = num;
            }
        }

        // с названием мог переборщить :)
        public void CopyOldAndCrateNewArray()
        {
            int[] tempArr = arr;
            capacity *= 2;
            arr = new int[capacity];
            int i = 0;
            foreach (int valueArr in tempArr)
            {
                arr[i] = valueArr;
                i++;
            }
        }

        public void RemoveAt(int index)
        {
            int[] tempArr = new int[capacity];
            int f = 0;
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (arr[i] == index)
                {
                    continue;
                }
                else
                {
                    tempArr[f] = arr[i];
                    f++;
                }
            }
            length--;
            arr = tempArr;
        }

        public void RemoveAllThisInstances(int value)
        {
            int[] tempArr = new int[capacity];
            int i = 0;
            foreach (int valueArr in arr)
            {
                if (valueArr == value)
                    continue;

                tempArr[i] = valueArr;
                i++;
            }
            arr = tempArr;
        }

        public void Clear()
        {
            arr = new int[4];
            length = 0;
            capacity = 4;
        }
    }
}
