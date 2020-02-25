namespace Chess {
  public class Board {
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
      if(Color == "White") {
        Color = "Black";
      } else {
        Color = "White";
      }
    }

    public bool CheckSpacesBetweenColumn(int rise) {
      if(rise > 0) {
          while(rise > 1){
            if (this.spaces[currentPiece.xCoord][currentPiece.yCoord + (rise - 1)] != null){
              return false;
            }
            rise --;
          }
        } else {
          while(rise < -1){
            if (this.spaces[currentPiece.xCoord][currentPiece.yCoord + (rise + 1)] != null){
              return false;
            }
            rise ++;
          }
        }
        return true;
    }

    public bool CheckSpacesBetweenRow(int run) {
                if(run > 0) {
          while(run > 1){
            if (this.spaces[currentPiece.xCoord + (run - 1)][currentPiece.yCoord] != null){
              return false;
            }
            run --;
          }
        } else {
          while(run < -1){
            if (this.spaces[currentPiece.xCoord + (run + 1)][currentPiece.yCoord] != null){
              return false;
            }
            run ++;
          }
        }
        return true;
    }

    public bool CheckSpacesBetweenDiagonal(int rise, int run) {
      if((run > 0) && (rise > 0)) {
          while(rise > 1){
            if (this.spaces[currentPiece.xCoord + (rise - 1)][currentPiece.yCoord + (rise - 1)] != null){
              return false;
            }
            rise --;
          }
        } else if ((run < 0) && (rise < 0)) {
          while(rise < -1){
            if (this.spaces[currentPiece.xCoord + (rise + 1)][currentPiece.yCoord + (rise + 1)] != null){
              return false;
            }
            rise ++;
          }
        } else if ((run > 0) && (rise < 0)) {
          while ((run > 1) && (rise < -1)) {
            if (this.spaces[currentPiece.xCoord + (run - 1)][currentPiece.yCoord + (rise + 1)] != null){
              return false;
            }
            run--;
            rise ++;
          }
        } else {
          while ((run < -1) && (rise > 1)) {
            if (this.spaces[currentPiece.xCoord + (run + 1)][currentPiece.yCoord + (rise - 1)] != null){
              return false;
            }
            run++;
            rise --;
          }
        }
    }
    public bool CheckViable(int x, int y) {
      Space targetSpace = spaces[x][y];

      // if you already have a piece in target, or your selected piece can't legally move like this, return false
      if (x == currentPiece.xCoord && y == currentPiece.yCoord)
      {
        return false;
      } 
      else if(targetSpace.Piece.Color == this.Color || !(currentPiece.CheckAll(x, y))) {
        return false;
      }
      // (if the selected piece is a king or knight, skip the next step)
      // if there is no piece/an enemy piece in target, but there are pieces in the way, return false
      int run  = targetSpace.Piece.xCoord - currentPiece.xCoord; 
      int rise = targetSpace.Piece.yCoord - currentPiece.yCoord;
      if(targetSpace.xCoord == currentPiece.xCoord) {
        if(!CheckSpacesBetweenColumn(rise)) {
          return false;
        }
      }
      else if (targetSpace.yCoord == currentPiece.yCoord) {
        if(!CheckSpacesBetweenRow(run)) {
          return false;
        }
      }
      else {
        if(!CheckSpacesBetweenDiagonal(rise, run)) {
          return false;
        }
      }
      return true;
    }

    public bool Move(int x, int y) {
      // code for "en passant" If the chess piece moves past a pawn
    }

    public bool Attack(int x, int y) {
      Space space = this.spaces[x][y];
      if(space.Piece != null) {
        space.Piece = null;
        space.Piece = this.currentPiece;
        return true;
      }
    }
  }
}
