using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public new static void UpdatePosition(string keyPressed, out int xCoordinate, out int yCoordinate)
        {
            switch(keyPressed)
            {
                case "LeftArrow":
                case "A":
                    xCoordinate = -1;
                    yCoordinate = 0;
                    break;
                case "RightArrow":
                case "D":
                    xCoordinate = 1;
                    yCoordinate = 0;
                    break;
                case "DownArrow":
                case "S":
                    xCoordinate = 0;
                    yCoordinate = 1;
                    break;
                case "UpArrow":
                case "W":
                    xCoordinate = 0;
                    yCoordinate = -1;
                    break;
                default:
                    xCoordinate = 0;
                    yCoordinate = 0;
                    break;
            }
        }
    public new static char UpdateCursor(string keyPressed) 
        {
            switch(keyPressed)
            {
                case "LeftArrow":
                case "A":
                    return '<';
                case "RightArrow":
                case "D":
                    return '>';
                case "DownArrow":
                case "S":
                    return 'v';
                case "UpArrow":
                case "W":
                    return '^';
                default:
                    return '<';
            }
        }
    public new static int KeepInBounds(int coordinate, int maxValue)
        {
            if(coordinate > maxValue)
            {
                return 0;
            } else if(coordinate < 0)
            {
                return maxValue;
            } else
            {
                return coordinate;
            }
        }
    public new static bool DidScore(int xCharCoordinate, int yCharCoordinate, int xFruitCoordinate, int yFruitCoordinate)
        {
            if (xCharCoordinate == xFruitCoordinate && yCharCoordinate == yFruitCoordinate)
            {
                return true;
            } else
            {
                return false;
            }
        }
  }
}