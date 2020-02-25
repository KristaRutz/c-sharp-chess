namespace Chess {

  public class Knight {

    public override string Name {
      get;
      set {
        string colorLetter = Color.Substring(0,1);
        Name = colorLetter + "Kn";
      }
    }

    public Knight(Space space) : base (space){}
    public override bool CheckAll(int x, int y){
      int run = x - this.space.xCoord;
      int rise = y -this.space.yCoord;
      if((Math.abs(run) == 2 && Math.abs(rise) == 1 ) ||  (Math.abs(run) == 1 && Math.abs(rise) == 2)) {
        return true;
      }
      else {
        return false;
      }
        
    }
  }
}