namespace SimpleMarsRover.Domain.Command
{
    internal class MoveForwardCommand : ICommand
    {
        public string MoveForwardGuid { get; set; }
    }
}