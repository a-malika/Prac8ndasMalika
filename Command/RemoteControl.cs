using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class RemoteControl
    {
        private ICommand[] Commands;
        private ICommand NoCommand;
        private Stack<ICommand> CommandHistory;
        private Stack<ICommand> UndoCommandHistory;
        public RemoteControl()
        {
            NoCommand = new NoCommand();
            Commands = new ICommand[5];
            for(int i = 0; i < 5; i++)
            {
                Commands[i] = NoCommand;
            }
            CommandHistory = new Stack<ICommand>();
            UndoCommandHistory = new Stack<ICommand>();
        }
        public void SetCommand(int key, ICommand command)
        {
            if (key >= 5 || key < 0)
            {
                Console.WriteLine("Кнопки с данным номером на пульте нет. Невозможно присвоить кнопке команду.");
                return;
            }
            Commands[key] = command;
        }
        public void PressButton(int key)
        {
            if (key >= 5 || key < 0)
            {
                Console.WriteLine("Кнопки с данным номером на пульте нет. Невозможно нажать кнопку.");
                return;
            }
            Commands[key].Execute();
            if(Commands[key] != NoCommand)
            {
                CommandHistory.Push(Commands[key]);
                UndoCommandHistory.Clear();
            }
        }
        public void PressUndoButton()
        {
            var check = CommandHistory.TryPop(out var LastCommand);
            if (check && LastCommand != null)
            {
                LastCommand.Undo();
                UndoCommandHistory.Push(LastCommand);
            }
            else NoCommand.Undo();
        }
        public void PressRedoButton()
        {
            var check = UndoCommandHistory.TryPop(out var LastCommand);
            if (check && LastCommand != null)
            {
                LastCommand.Execute();
                CommandHistory.Push(LastCommand);
            }
            else NoCommand.Undo();
        }
    }
}
