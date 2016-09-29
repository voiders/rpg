
public class Weapon : StatItem { // BaseWeapon <- BaseStatItem -< BaseItem 
  public enum WeaponTypes{
    SWORD,
    STAFF,
    DAGGER,
    BOW,
    SHIELD,
    POLEARM
  }
  private int spellEffectID;

  private WeaponTypes weaponType;

  public WeaponTypes WeaponType {
    get {return weaponType;}
    set { weaponType = value;}
  }
  public int SpellEffectID {
    get {return spellEffectID;}
    set { spellEffectID = value;}
  }
}
