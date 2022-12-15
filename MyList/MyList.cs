using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T> : IEnumerable, IEnumerator
    {
        int count = 0;
        int capacity = 2;
        public int Capacity { get => capacity; }
        public int Count { get => count; }

        T[] mass = new T[1];

        int position = -1;
        int pos = -1;

        public void Clear()
        {
            mass = new T[1];
            count = 0;
            capacity = 2;
            pos = -1;
        }

        public bool Contains(T item)
        {

            foreach (T val in mass)
            {
                if (val.Equals(item))
                    return true;
            }
            return false;
        }

        public void Add(T mass)
        {
            if (this.mass.Length == this.Capacity)
            {
                this.capacity *= 2;
            }

            Array.Resize(ref this.mass, this.Capacity);

            count++;
            pos++;
            this.mass[pos] = mass;
        }

        /*
        public void Add(T mass)
        {
            count++;
            Array.Resize(ref this.mass, count);
            pos++;
            this.mass[pos] = mass;
        }
        */

        public void Remove(T mass)
        {
            count--;
            pos--;
            T[] massArray = new T[count];
            for (int i = 0; i < count; i++)
            {
                if (i != pos)
                {
                    massArray[i] = this.mass[i];
                }
            }
            this.mass = massArray;
        }

        public void RemoveByIndex(int index)
        {
            count--;
            pos--;
            T[] massArray = new T[count];
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    Console.WriteLine(i);
                    massArray[i] = this.mass[i];
                }
            }
            this.mass = massArray;
        }

        public bool MoveNext()
        {
            position++;
            return (position < mass.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public T Current
        {
            get { try { return mass[position]; } catch (IndexOutOfRangeException) { throw new InvalidOperationException(); } }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public IEnumerator GetEnumerator()
        {
            return mass.GetEnumerator();
        }

        public T this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }
    }
}
