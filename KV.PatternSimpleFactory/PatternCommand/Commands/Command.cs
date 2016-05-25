namespace PatternCommand.Commands
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}