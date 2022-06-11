using System;

namespace SimpleMarsRover
{
    internal class Plateu
    {
        private Position position;

        public string[,] Board { get; }
        public string Direction { get; }

        public Plateu()
        {
            Board = CreateBoard();
            Direction = "N";
        }

        internal void Move(string input)
        {
            position = new Position(0, input.Length);
        }

        private string[,] CreateBoard()
        {
            string[,] board = new string[10, 10];
            
            for (var x = 0; x < board.GetLength(0); x++) 
            {
                for (var y = 0; y < board.GetLength(1); y++) 
                {
                    board[x, y] = x.ToString() +":"+ y.ToString();
                }
            }

            return board;
        }

        public string Print()
        {
            return Board[position.X, position.Y].ToString() + ":" + Direction;
        }
    }
}