
namespace Day12
{
    public class DataStorageWithArray<T>
    {
        private T[] _data = new T[10];

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return _data[index];
            }
            else
                return default(T);
        }

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

    }
}
