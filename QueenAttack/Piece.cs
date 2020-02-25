namespace Chess {
public abstract class Piece {

  public string Color { get; set;}

  public Space Space { get; set;}
  public int xCoord  { 
    get;
    set {
      xCoord = this.Space.xCoord;
    }
  }
  public int yCoord {
    get; 
    set {
      yCoord = this.Space.yCoord;
    } 
  }
  public virtual string Name {
    get;
    set {
      string colorLetter = Color.Substring(0,1);
      Name = colorLetter + this.GetType().Name.Substring(0,1);
    }
  }

  public abstract bool CheckAll();
  }
}
