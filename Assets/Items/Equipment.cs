
public class Equipment : StatItem {

  public enum EquipmentTypes {
    HEAD,
    CHEST,
    SHOULDERS,
    LEGS,
    FEET,
    NECK
  }

  private EquipmentTypes equipmentType;
  private int spellEffectID;

  public EquipmentTypes EquipmentType {
    get { return equipmentType;}
    set { equipmentType = value;}
  }
  public int SpellEffectID {
    get { return spellEffectID;}
    set { spellEffectID = value;}
  }
}