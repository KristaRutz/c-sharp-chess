namespace Chess {
  public class Bishop : Piece {
    
    
    public override void Move(Board b) {
      int x = base.xCoord;
      int y = base.yCoord;
    }

    public override void Attack() {
    }


    public override bool CheckAll(int x, int y) {
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