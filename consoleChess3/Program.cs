using System;

namespace consoleChess3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            bool state = false;

            switch (name)
            {
                case "K":
                    Chess figure = new King(x1, y1);
                    state = figure.Move(x2, y2);
                    break;
                case "Q":
                    figure = new Queen(x1, y1);
                    state = figure.Move(x2, y2);
                    break;
                case "B":
                    figure = new Bishop(x1, y1);
                    state = figure.Move(x2, y2);
                    break;
                case "N":
                    figure = new Knight(x1, y1);
                    state = figure.Move(x2, y2);
                    break;
                case "R":
                    figure = new Rook(x1, y1);
                    state = figure.Move(x2, y2);
                    break;

                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    break;
            }

            Console.WriteLine(state ? "YES" : "NO");

        }
    }


    class Chess
    {
        public int x;
        public int y;

        public Chess(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    class King : Chess
    {
        public King(int x, int y) : base(x, y)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(newX - x) <= 1 && Math.Abs(newY - y) <= 1)
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Queen : Chess
    {
        public Queen(int x, int y) : base(x, y)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (x == newX || y == newY || Math.Abs(newX - x) == Math.Abs(y - newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Rook : Chess
    {
        public Rook(int x, int y) : base(x, y)
        {

        }

        public override bool Move(int newX, int newY)
        {

            if (x == newX || y == newY)
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Knight : Chess
    {
        public Knight(int x, int y) : base(x, y)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(newX - x) == 1 && Math.Abs(newY - y) == 2 || Math.Abs(newX - x) == 2 && Math.Abs(newY - y) == 1)
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bishop : Chess
    {
        public Bishop(int x, int y) : base(x, y)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(newX - x) == Math.Abs(newY - y))
            {
                x = newX;
                y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
