namespace LD53
{
    public class InventoryBase<T> : IInventory<T>
    {
        protected int capacity;
        protected int maxCapacity;

        public InventoryBase()
        {
            capacity = 0;
            maxCapacity = 0;
        }

        public virtual bool SetCapacity(int newsize)
        {
            return false;
        }
        public virtual int GetCapacity()
        {
            return maxCapacity;
        }
        public virtual int GetSize()
        {
            return 0;
        }
        public virtual bool AddItem(T item)
        {
            return false;
        }
        public virtual bool RemoveItem(T item)
        {
            return false;
        }
    }
}