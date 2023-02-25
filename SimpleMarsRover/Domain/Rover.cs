using SimpleMarsRover.Domain.Command;
using SimpleMarsRover.Logging;

namespace SimpleMarsRover.Domain
{
    internal class Rover
    {
        private Position position;
        private Direction direction;
        private string[,] board;
        private readonly ILogger logger;

        public Rover(ILogger logger)
        {
            board = CreateBoard();
            direction = new Direction();
            position = new Position(0, 0);
            this.logger = logger;
        }

        public void Move(string input)
        {
            if (input.Length == 0) return;

            for (var i = 0; i < input.Length; i++)
            {
                ICommand command = CommandFactory(input[i]);
                ICommandHandler commandHandler = CommandHandlerFactory(command.GetType());
                commandHandler.Handle(command);
            }
        }

        private ICommandHandler CommandHandlerFactory(Type commandType)
        {
            if (commandType == typeof(TurnRightCommand))
                return new TurnRightCommandHandler(this, logger);
            if (commandType == typeof(TurnLeftCommand))
                return new TurnLeftCommandHandler(this, logger);

            return new MoveForwardCommandHandler(this, logger);
        }

        private ICommand CommandFactory(char input)
        {
            if (input == 'R') return new TurnRightCommand();
            if (input == 'L') return new TurnLeftCommand();

            return new MoveForwardCommand();
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
                    board[x, y] = x.ToString() + ":" + y.ToString();
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