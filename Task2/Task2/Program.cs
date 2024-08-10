using MyClasses;

internal class Program
{
  private static void Main(string[] args)
  {
    Inventory<Item> inventory = new Inventory<Item>();
    inventory.AddItem(new Item("Laptop", "Dev", ItemType.WorkItem));
    inventory.AddItem(new Item("qwerty", "PC", ItemType.OfficeItem));
    inventory.AddItem(new Item("zxc", "coffee", ItemType.HomeItem));

    Console.WriteLine("All items:");
    foreach (var item in inventory.GetAllItems())
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("\nItems in 'PC':");
    foreach (var item in inventory.GetItemsByCategory("PC"))
    {
      Console.WriteLine(item);
    }

    Console.WriteLine("\nItems of type 'qwerty':");
    foreach (var item in inventory.GetItemsByType(ItemType.HomeItem))
    {
      Console.WriteLine(item);
    }

    var itemToRemove = new Item("zxc", "coffee", ItemType.HomeItem);
    inventory.RemoveItem(itemToRemove);

    Console.WriteLine("\nAll items after removal:");
    foreach (var item in inventory.GetAllItems())
    {
      Console.WriteLine(item);
    }
  }
}