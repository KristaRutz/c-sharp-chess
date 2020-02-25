namespace Chess {

  public class Rook {

    public Rook(Space space) : base (space){}
    public override bool CheckAll(int x, int y) {
      if(CheckSameColumn(x, y) || CheckSameRow(x, y)) {
          return true;
        } else {
          return false;
        }
     }

    public bool CheckSameColumn(int x, int y) {
      if(XCoord == x) {
        return true;
      } else {
        return false;
      }
    }
    public bool CheckSameRow(int x, int y) {
      if(YCoord == y) {
        return true;
      } else {
        return false;
      }
    }
  }
}