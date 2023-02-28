﻿namespace SimpleMarsRover.Domain
{
    public class Rover : IRover
    {
        private Position position;
        private Direction direction;
        private string[,] board;

        public Rover()
        {
            board = CreateBoard();
            direction = new Direction();
            position = new Position(0, 0);
        }
        
        public void MoveForward()
        {
            position = position.Update(direction.ToString());
        }

        public void TurnRight()
        {
            direction.TurnRight();
        }

        public void TurnLeft()
        {
            direction.TurnLeft();
        }

        public string Print()
        {
            return board[position.ToPairInt().Item1, position.ToPairInt().Item2].ToString() + ":" + direction.ToString();
        }

        private string[,] CreateBoard()
        {
            string[,] board = new string[10, 10];

            for (var x = 0; x < board.GetLength(0); x++)
            {
                for (var y = 0; y < board.GetLength(1); y++)
                {
                    board[x, y] = x.ToString() + ":" + y.ToString();
                }
            }

            return board;
        }
    }
}