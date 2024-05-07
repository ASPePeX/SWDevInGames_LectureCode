namespace Todo3
{
    public class MyCollection<T> where T : IComparable
    {
        private T[] _theObjects;
        private int _n;

        public T this[int i]
        {
            get { return GetAt(i); }
            set { SetAt(value, i); }
        }

        public MyCollection()
        {
            _theObjects = new T[2];
            _n = 0;
        }

        public void Add(T t)
        {
            // If necessary, grow the array
            if (_n == _theObjects.Length)
            {
                T[] oldArray = _theObjects;
                _theObjects = new T[2 * oldArray.Length];
                Array.Copy(oldArray, _theObjects, _n);
            }

            _theObjects[_n] = t;
            _n++;
        }

        public T GetAt(int i)
        {
            return _theObjects[i];
        }

        public void SetAt(T t, int index)
        {
            if (index >= _n)
            {
                throw new IndexOutOfRangeException();
            }

            _theObjects[index] = t;
        }

        public int Count
        {
            get { return _n; }
        }
    }
}
