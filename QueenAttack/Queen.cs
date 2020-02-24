using System;

namespace Chess {
public class Queen {
  
  public int XCoord {get; set;}
  public int YCoord {get; set;}
  public Queen(int xCoord, int yCoord) {
      XCoord = xCoord;
      YCoord = yCoord;
  }

  public bool CheckAll(int x, int y) {
    if(CheckSameColumn(x, y) || CheckSameRow(x, y) || CheckDiagonal(x,y)) {
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
  public bool CheckDiagonal(int x, int y) {
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