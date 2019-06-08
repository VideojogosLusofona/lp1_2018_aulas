using System;

namespace Exercicio5
{
    public class Guarda3<T>
    {
        private T v1, v2, v3;

        public Guarda3()
        {
            v1 = default(T);
            v2 = default(T);
            v3 = default(T);
        }

        public T GetItem(int i)
        {
            if (i == 0) return v1;
            if (i == 1) return v2;
            if (i == 2) return v3;
            throw new IndexOutOfRangeException();
        }

        public void SetItem(int i, T item)
        {
            if (i == 0) v1 = item;
            else if (i == 1) v2 = item;
            else if (i == 2) v3 = item;
            else throw new IndexOutOfRangeException();
        }
    }
}
