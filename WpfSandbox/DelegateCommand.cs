namespace WpfSandbox
{
    using System;
    using System.Windows.Input;

    public class DelegateCommand : ICommand
    {
        private readonly Action<object> action;

        public DelegateCommand(Action<object> action)
        {
            this.action = action;
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
