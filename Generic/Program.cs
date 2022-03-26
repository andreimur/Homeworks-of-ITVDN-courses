using System;

namespace Generic
{

    class MyList<T>
    {
        private T[] array = new T[100];
        
        public int Count
        {
            get { return array.Length; }
        }
        
        public void Add(T arg)
        {
            array[0] = arg;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        
    }

    static class  New
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = list[i];

            }
            return arr;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            int count  = list.Count;
            list.Add(4);
            list[4] = 6;
            Console.WriteLine(count);
            Console.WriteLine(list[0]);
            Console.WriteLine("---------------");
            int[] arr = list.GetArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
