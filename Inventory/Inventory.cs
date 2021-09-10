using System;
using System.Collections.Generic;

namespace InventoryGuide
{
    public class Inventory
    {
        public List<Item> ItemsDB = new List<Item>();
        public List<Slot> InventoryArray { get; set; }

        public Inventory(int capacity)
        {
            if (capacity > 0)
            {
                InventoryArray = new List<Slot>();
                for (int i = 0; i < capacity; i++)
                {
                    InventoryArray.Add(new Slot());
                }
            }
        }

        public void CreateHealing(string title, bool canStack, int power)
        {
            if (title != "" && power > 0)
            {
                Item.Healing item = new Item. Healing { title = title, canStack = canStack, id = ItemsDB.Count, Power = power };
                ItemsDB.Add(item);
            }
        }

        public void CreateResource(string title, bool canStack)
        {
            if (title != "")
            {
                Item.Resource item = new Item.Resource { title = title, canStack = canStack, id = ItemsDB.Count };
                ItemsDB.Add(item);
            }
        }
           
        public bool AddItem(Item item, int count)
        {
            bool added = false;

            if (item != null && count > 0)
            {
                for (int i = 0; i < InventoryArray.Count; i++)
                {
                    if (InventoryArray[i].item == null)
                    {
                        InventoryArray[i].item = item;
                        InventoryArray[i].count = count;
                        added = true;
                        break;
                    }
                    else
                    if (InventoryArray[i].item == item && item.canStack)
                    {
                        InventoryArray[i].count += count;
                        added = true;
                        break;
                    }
                }
            }
            return added;
        }

        public bool AddItem(int id, int count)
        {
            bool added = false;

            if (id >= 0 && id < ItemsDB.Count && count > 0)
            {
                Item item = ItemsDB[id];

                if (item != null)
                {
                    for (int i = 0; i < InventoryArray.Count; i++)
                    {
                        if (InventoryArray[i].item == null)
                        {
                            InventoryArray[i].item = item;
                            InventoryArray[i].count = count;
                            added = true;
                            break;
                        }
                        else
                        if (InventoryArray[i].item == item && item.canStack)
                        {
                            InventoryArray[i].count += count;
                            added = true;
                            break;
                        }
                    }
                }
            }       
            return added;
        }

        public void DropItem(int slotID, int count = 0)
        {
            if (slotID >= 0 && slotID < InventoryArray.Count)
            {
                Item item = InventoryArray[slotID].item;
                if (count == 0 || InventoryArray[slotID].count <= count)
                {
                    InventoryArray[slotID].item = null;
                    InventoryArray[slotID].count = 0;
                }
                else
                {
                    InventoryArray[slotID].count -= count;
                }
                //DROP item
            }
        }

        public void ShowInConsole()
        {
            for (int i = 0; i < InventoryArray.Count; i++)
            {
                if (InventoryArray[i].item == null) Console.Write("none");
                else Console.Write($"{InventoryArray[i].item.title} ({InventoryArray[i].count})");
                Console.Write(" | ");
            }
        }
    }

    public class Item
    {
        public string title { get; set; }
        public bool canStack { get; set; }
        public int id { get; set; }

        public class Healing : Item
        {
            public int Power { get; set; }
        }

        public class Resource : Item
        {
            //fields
        }
    }

    public class Slot
    {
        public Item item { get; set; }
        public int count { get; set; }
    }
}


