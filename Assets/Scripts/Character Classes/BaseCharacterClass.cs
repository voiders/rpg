public class BaseCharacterClass {
  private string characterClassName;
  private string characterClassDescription;
  // states
  private int staminia;
  private int endurance;
  private int strength;
  private int intellect;

  public string CharacterClassName {
    get{return characterClassName;}
    set{characterClassName = value;} 
  }
  public string CharacterClassDescription {
    get{return characterClassDescription;}
    set{characterClassDescription = value;} 
  }
  public int Staminia {
    get{return staminia;}
    set{staminia = value;} 
  }
  public int Endurance {
    get{return endurance;}
    set{endurance = value;} 
  }
  public int Strength {
    get{return strength;}
    set{strength = value;} 
  }
  public int Intellect {
    get{return intellect;}
    set{intellect = value;} 
  }

}
