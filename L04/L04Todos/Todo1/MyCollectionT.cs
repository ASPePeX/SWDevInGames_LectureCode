namespace Todo1
{
    public class MyCollection<T>
    {
        private T[] _theObjects;
        private int _n;

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

        public int Count
        {
            get { return _n; }
        }
    }
}
