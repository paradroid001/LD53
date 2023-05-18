using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LD53
{
    public class MonoBasicInventory : MonoBehaviour
    {
        BasicInventory<Item> _inventory;
        [SerializeField]
        private int maxInventorySize = 5;
        // Start is called before the first frame update
        void Awake()
        {
            _inventory = new BasicInventory<Item>(maxInventorySize);
        }

        void Start()
        {

        }

        void Add(Item i)
        {
            bool result = _inventory.AddItem(i);
            if (!result)
            {
                Log.Debug("could not add item");
            }
            else
            {
                Log.Debug($"inventory now holds {_inventory.GetSize()} items");
            }
        }

        void Remove(Item i)
        {
            bool result = _inventory.RemoveItem(i);
            if (!result)
            {
                Log.Debug("could not remove item");
            }
            else
            {
                Log.Debug($"inventory now holds {_inventory.GetSize()} items");
            }
        }

    }
}