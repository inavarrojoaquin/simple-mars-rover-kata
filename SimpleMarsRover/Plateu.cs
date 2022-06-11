using System;

namespace SimpleMarsRover
{
    internal class Plateu
    {
        private int positionX;
        private int positionY;

        public string[,] Board { get; }
        public string Position { get; }

        public Plateu()
        {
            Board = CreateBoard();
            Position = "N";
        }

        internal void Move(string input)
        {
            if (string.IsNullOrEmpty(input)) return;

            positionX = 0;
            positionY = input.Length;
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
            return Board[positionX, positionY].ToString() + ":" + Position;
        }
    }
}