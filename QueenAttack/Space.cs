namespace Chess {
  public class Space {
    public Piece Piece {get; set;}
    public int xCoord { get; set;}
    public int yCoord {get; set;}

    public Space(int x, int y) {
      xCoord = x;
      yCoord = y;
      Piece = null;
    }
  }
}