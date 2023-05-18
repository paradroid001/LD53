namespace LD53
{
    public interface IInventory<T>
    {
        public bool SetCapacity(int size);
        public int GetCapacity();
        public int GetSize();
        public bool AddItem(T item);
        public bool RemoveItem(T item);
    }
}