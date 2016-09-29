public class Item {

  private string name;
  private string description;
  private int id;
  public enum ItemTypes{
    EQUIPMENT,
    WEAPON,
    SCROLL,
    POTION,
    CHEST
  }

  private ItemTypes itemType;

  public string Name {
    get { return name; }
    set { name = value; }
  }
  public string ItemDescription{
    get { return description; }
    set { description = value; }
  }
  public int ItemID{
    get { return id; }
    set { id = value; }
  }
  public ItemTypes ItemType{
    get { return itemType; }
    set { itemType = value; }
  }
}