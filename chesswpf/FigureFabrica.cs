using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary;

namespace chesswpf
{
    class FigureFabrica
    {
        static public Chess Make(string _name, int x, int y)
        {
            Chess figure = null;
            switch (_name)
            {
                case "K":
                    figure = new King(x, y);
                   
                    break;
                case "Q":
                    figure = new Queen(x, y);
                    
                    break;
                case "B":
                    figure = new Bishop(x, y);
                    
                    break;
                case "N":
                    figure = new Knight(x, y);
                   
                    break;
                case "R":
                    figure = new Rook(x, y);
                  
                    break;

                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    break;
            }

            return figure;
        }

        static public Chess Make(int pieceCode, int x, int y)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }
}
