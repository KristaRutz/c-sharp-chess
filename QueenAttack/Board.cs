namespace Chess {

  public class Board {
    
    public bool isBlack { get; set; }
    public string Color { get; set; }

    public Piece currentPiece {get; set; }
    public Array[] spaces = new Array[];
    
    public Board() {
      Color = "White";
      for(int i = 0; i < 8; i++) {
        Space[] row = new Space[];
        for(int j = 0; j < 8; j++) {
          row.Add(new Space(i, j));
        }
        spaces.Add(row);
      }
    }

    public bool SelectPiece(int x, int y) {
      Space s = spaces[x][y];
      Piece p = s.Piece;
      if(Color == p.Color) {
        currentPiece = p;
        return true;
      } else {
        return false;
      }
    }
    public void ChangePlayer() {
      isBlack = !isBlack;
    }
  }
}