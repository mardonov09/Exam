using System.IO.Compression;

namespace MyClasses;
public enum ItemType
{
  HomeItem,
  WorkItem,
  OfficeItem
}

public class Item
{
  public string? Name { get; set; }
  public string? Category { get; set; }
  public ItemType Type { get; set; }

  public Item(string name, string category, ItemType type)
  {
    Name = name;
    Category = category;
    Type = type;
  }
  public override string ToString()
  {
    return $"{Name} (Category: {Category}, Type: {Type})";
  }
}


public class Inventory<T> where T : Item
{
  public List<T> items = new List<T>();

  public void AddItem(T item)
  {
    items.Add(item);
  }

  public void RemoveItem(T item)
  {
    items.Remove(item);
  }

  public IEnumerable<T> GetItemsByCategory(string category)
  {
    return items.Where(item => item.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
  }

  public IEnumerable<T> GetItemsByType(ItemType type)
  {
    return items.Where(item => item.Type == type);
  }

  public IEnumerable<T> GetAllItems()
  {
    return items;
  }
}
// Требования:

// - `Item`: класс, представляющий универсальный элемент в инвентаре с базовыми свойствами, такими как

//   - Name - `string`
//   - Category - `string`
//   - Type - `enum` ( `HomeItem`, `WorkItem`, `OfficeItem` и другие )

// - `Inventory<T>`: класс, который управляет коллекцией элементов, где `T` - тип элемента.

// Реализуйте методы для добавления элементов, удаления элементов и фильтрации по типу и категории.

// - `AddItem(T item)`
// - `RemoveItem(T item)`
// - `GetItemsByCategory(string category)`
// - `GetItemsByType(YourEnum type)`
// - `GetAllItems()`

