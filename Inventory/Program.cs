using System;

namespace InventoryGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryWork();
        } 

        static void InventoryWork()
        {
            Inventory inv = new Inventory(10);

            inv.CreateHealing("Small Healing", true, 10);
            inv.CreateHealing("Medium Healing", true, 50);
            inv.CreateHealing("Large Healing", false, 100);
            inv.CreateResource("Wood", true);
            inv.CreateResource("Stone", true);
            inv.CreateResource("Wood Log", false);

            inv.AddItem(0, 1);
            inv.AddItem(0, 1);
            inv.AddItem(0, 1);
            inv.AddItem(0, 1);

            inv.AddItem(1, 1);
            inv.AddItem(1, 1);

            inv.AddItem(2, 1);

            inv.AddItem(3, 1);
            inv.AddItem(3, 1);

            inv.AddItem(4, 1);
            inv.AddItem(4, 1);

            inv.AddItem(5, 1);
            inv.AddItem(5, 1);

            inv.AddItem(99, 1);

            inv.ShowInConsole();
            Console.WriteLine();
            Console.ReadLine();

            inv.DropItem(3, 3);
            inv.AddItem(2, 1);
            inv.ShowInConsole();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
