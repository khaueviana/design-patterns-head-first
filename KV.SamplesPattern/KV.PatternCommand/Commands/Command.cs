namespace KV.PatternCommand.Commands
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}