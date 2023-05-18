using System.Collections;
using System.Collections.Generic;

namespace LD53
{
    public class BasicInventory<T> : InventoryBase<T>
    {
        protected List<T> items;

        public BasicInventory() : base()
        {
            items = new List<T>();
        }
        public BasicInventory(int capacity) : this()
        {
            SetCapacity(capacity);
        }

        public override bool SetCapacity(int newsize)
        {
            if (newsize < maxCapacity && newsize < items.Count)
            {
                return false; //tried to reduce size to less than 
            }
            maxCapacity = newsize;
            return true;
        }

        public override int GetSize()
        {
            return items.Count;
        }

        public override bool AddItem(T item)
        {
            if (!items.Contains(item) && items.Count < maxCapacity)
            {
                items.Add(item);
                return true;
            }
            return false;
        }

        public override bool RemoveItem(T item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }
            return false;
        }

    }
}