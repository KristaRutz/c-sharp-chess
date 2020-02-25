namespace Chess {
  public class Bishop : Piece 
  {
    public Bishop(Space space) : base (space){
    }
    public override bool CheckAll(int x, int y) 
    {
      int rise = (y - YCoord);
      int run = (x - XCoord);
      if(Math.Abs(rise/run) == 1) {
        return true;
      } else {
        return false;
      }
    }
  }
}