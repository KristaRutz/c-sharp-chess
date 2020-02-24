namespace Chess {
public abstract class Piece {

  public string Color { get; set;}
  public int xCoord {get; set;}
  public int yCoord {get; set;}

  public abstract int ColumnMovement;
  public abstract int RowMovement;
  public abstract int Diagonal;

  public string Name {
        get;
        set {
          string colorLetter = Color.Substring(0,1);
          Name = colorLetter + this.GetType().Name.Substring(0,1);
        }
      }

  public abstract void Move();

  public abstract void Attack();

  public abstract bool CheckAll();

  //check
  }
}
