using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryGuide
{
    public class Craft
    {
        //НЕ РАБОТАЕТ
        public List<CraftInfo> CraftsDB = new List<CraftInfo>();
        private Inventory inv { get; set; }

        public Craft(Inventory inv)
        {
            if (inv != null)
            {
                this.inv = inv;
            }
        }

        public void CreateCraft(Item[] items, Item result)
        {
            if (items != null && result != null)
            {
                if (items.Length > 0)
                {
                    CraftInfo info = new CraftInfo { items = items.ToList(), result = result };
                    CraftsDB.Add(info);
                }
            }
        }

        /*
        // NOT WORK
        public bool CraftItem(Item item)
        {
            bool added = false;

            if (item != null)
            {
                foreach (CraftInfo info in CraftsDB)
                {
                    if (info.result == item)
                    {
                        List<Item> need = info.items;
                        for (int i = 0; i < inv.InventoryArray.Length; i++)
                        {
                            if (need.Count > 0)
                            {
                                //if ()
                            }
                        }
                        if (inv != null) inv.AddItem(item);
                    }
                    break;
                }
            }
            return added;
        }
        // NOT WORK
        public bool CraftItem(int id)
        {
            bool added = false;
            Item item = ItemsDB[id];

            if (item != null)
            {
                for (int i = 0; i < InventoryArray.Length; i++)
                {
                    if (InventoryArray[i].item == null)
                    {
                        InventoryArray[i].item = item;
                        added = true;
                        break;
                    }
                    else
                    if (InventoryArray[i].item == item && item.canStack)
                    {
                        InventoryArray[i].count += 1;
                        added = true;
                        break;
                    }
                }
            }
            return added;
        }
    }*/

        public class CraftInfo
        {
            public List<Item> items = new List<Item>();
            public Item result { get; set; }
        }
    }
}