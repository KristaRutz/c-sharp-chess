using System;
using Chess;
class Program
{
  
  static void PrintBoard()
  {
    Console.WriteLine("CURRENT BOARD");
    Console.WriteLine(" [0] [1] [2] [3] [4] [5] [6] [7]");
    for (int row = 0; row < 8; row++)
    {
      Console.WriteLine(row + "[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]");
    }
    
  }
  static void Main()
  {
    PrintBoard();
    //If player is white, user can select white pieces
    //board uses selectPiece, current Piece = 
  //  Console.WriteLine("Determine if a queen can attack another chess piece.");
  //  Console.WriteLine("Enter coordinates for the queen.");
  //  Console.WriteLine("Enter x coordinate.");
  //  string queenXCoord = Console.ReadLine();
  //  int queenX = int.Parse(queenXCoord);
  //  Console.WriteLine("Enter y coordinate.");
  //  string queenYCoord = Console.ReadLine();
  //  int queenY = int.Parse(queenYCoord);
  //  Queen q = new Queen(queenX, queenY);
  //  Console.WriteLine("Enter coordinates for the other chess piece.");
  //  Console.WriteLine("Enter x coordinate.");
  //  string pieceXCoord = Console.ReadLine();
  //  int pieceX = int.Parse(pieceXCoord);
  //  Console.WriteLine("Enter y coordinate.");
  //  string pieceYCoord = Console.ReadLine();
  //  int pieceY = int.Parse(pieceYCoord);
  //  bool attackable = q.CheckAll(pieceX, pieceY);
  //  if(attackable) {
  //    Console.WriteLine("The queen can attack the other piece.");
  //    Console.WriteLine("Piece out.");
  //  } else {
  //    Console.WriteLine("The queen can't attack the other piece.");
  //    Console.WriteLine("Piece out.");
  //  }
  //  Main();
  }
}