using System;

namespace SimpleMarsRover
{
    internal class Plateu
    {
        private Position position;
        private Direction direction;
        private string[,] board;
        
        public Plateu()
        {
            board = CreateBoard();
            direction = new Direction();
            position = new Position(0, 0);
        }

        internal void Move(string input)
        {
            if (input.Length == 0) return;
            
            for (var i = 0; i < input.Length; i++) 
            {
                if (input[i] == 'M') position = new Position(0, position.Y + 1);
                if (input[i] == 'R') direction.TurnRight();
            }
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
            return board[position.X, position.Y].ToString() + ":" + direction.Name;
        }
    }
}