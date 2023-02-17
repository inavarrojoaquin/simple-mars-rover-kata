namespace SimpleMarsRover
{
    internal class Rover
    {
        private Position position;
        private Direction direction;
        private string[,] board;
        private IRoverCommand command;

        public Rover()
        {
            board = CreateBoard();
            direction = new Direction();
            position = new Position(0, 0);
        }

        public void Move(string input)
        {
            if (input.Length == 0) return;
            
            for (var i = 0; i < input.Length; i++) 
            {
                command = RoverCommandFactory.Create(input[i], this);
                command.Execute();
            }
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
            return board[position.ToPairInt().Item1, position.ToPairInt().Item2].ToString() + ":" + direction.ToString();
        }
    }
}