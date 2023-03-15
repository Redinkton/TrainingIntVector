using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingIntVector
{
    public class IntVector
    {
        int length = 0;
        int capacity=4;
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

        public void Add(int num)
        {
            if (length > capacity-1)
            {
                NewArray();
                arr[length++] = num;
            }
            else
            {
                arr[length++] = num;
            }
        }
        public int Capacity()
        {
            return capacity;
        }
        public int Length()
        {
            return length;
        }
        public void NewArray()
        {
            int[] tempArr = arr;
            capacity = capacity*2;
            arr = new int[capacity];
            int temp = 0;
            foreach (int i in tempArr)
            {
                arr[temp++]= i;
            }
        }
        public void AddToEnd(int num)
        {
            if (length<capacity)
            {
                arr[arr.Length-1] = num;
            }
            else if (length > capacity)
            {
                NewArray();
                arr[arr.Length - 1] = num;
            }
            else if (length == capacity)
            {
                NewArray();
                arr[length] = num;
            }
        }
    }
}
