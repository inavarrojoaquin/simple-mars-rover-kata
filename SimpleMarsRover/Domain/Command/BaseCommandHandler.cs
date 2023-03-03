namespace SimpleMarsRover.Domain.Command
{
    public abstract class BaseCommandHandler : ICommandHandler
    {
        protected ICommandHandler nextHandler;
        public void SetNextHandler(ICommandHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void Handle(char input);        
    }
}