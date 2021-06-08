using System;

namespace ClassLibrary1
{
    public class Class1
    {
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
}

