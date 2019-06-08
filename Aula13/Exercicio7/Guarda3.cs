using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercicio7
{
    public class Guarda3<T> : IEnumerable<T>
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

        public void Add(T item)
        {
            if (Equals(v1, default(T))) v1 = item;
            else if (Equals(v2, default(T))) v2 = item;
            else if (Equals(v3, default(T))) v3 = item;

            // We cant use the == operator because we don't know if type T has
            // such operator

            // We also cant use the obj1.Equals(obj2) method because obj1
            // (in this case v1, v2 or v3) might be null, which is the default
            // value for reference types

            // As such we must use the static object.Equals(obj1, obj2) method
            // for performing comparison between instances
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return v1;
            yield return v2;
            yield return v3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
