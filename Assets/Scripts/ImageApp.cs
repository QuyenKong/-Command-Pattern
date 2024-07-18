using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class ImageApp
    {
        private Stack<ICommand> _commandStack;
        
        public ImageApp()
        {
            _commandStack = new Stack<ICommand>();
        }
        
        public void AddCommand(ICommand newCommand)
        {
            newCommand.Execute();
            _commandStack.Push(newCommand);
        }
        
        public void Undo()
        {
            if(_commandStack.Count > 0)
            {
                ICommand command = _commandStack.Pop();
                command.Undo();
            }
        }
    }
}