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

      string direction;
      if(targetSpace.xCoord == currentPiece.xCoord) {
        //direction = "column";
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
      }
      else if (targetSpace.yCoord == currentPiece.yCoord) {
        //direction = "row";
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
      }
      else {
        //direction = "diagonal";
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
      //will return either positive or negative

      
      int increaseOrDecrease;
      //bool containsAPiece;
      // if(direction == "column") {

      // } 
      else if (direction == "row") {
        if(run > 0) {
          increaseOrDecrease = 1;
        } else {
          increaseOrDecrease = -1;
        }
        //spaces array with row direction
      } else {
        if(rise/run > 0) {
          increaseOrDecrease = 1;
        } else {
          increaseOrDecrease = -1;
        }
        //spaces array with diagonal direction
      }

      while()
      Space[] spacesBetween = new Space[];

      if(s.Piece == null && s.Piece.CheckAll(x, y)) {
        
        //lets get coordinates of the current piece
        //lets get all spaces between piece space and inputted coordinates, if a non null or same color 
        //if there is a piece in the way, and you cant jump over the piece.
        //return false;
        //otherwise
      }
      if(s.Piece.Color == this.Color) {
        return false;
      }
      if(s.Piece) {

      } 

      // there is no piece/an enemy piece in target or in the way, so we return true
    }
  }
}