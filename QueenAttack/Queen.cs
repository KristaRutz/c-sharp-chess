using System;

namespace Chess {
public class Queen {
  
  public Queen(Space space) : base (space) {
    XCoord = space.XCoord;
    YCoord = space.yCoord;
  }

  public override bool CheckAll(int x, int y) {
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