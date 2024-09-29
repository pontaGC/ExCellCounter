using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace ExCellCounter.Presentation.Core.Mvvm
{
    /// <summary>
    /// The relay command base.
    /// </summary>
    public abstract class RelayCommandBase : IRelayCommand
    {
        #region Fields

        private event EventHandler? internalCanExecuteChanged;

        #endregion

        #region Explict interface implementation

        event EventHandler? ICommand.CanExecuteChanged
        {
            add => this.internalCanExecuteChanged += value;
            remove => this.internalCanExecuteChanged -= value;
        }

        bool ICommand.CanExecute(object? parameter)
        {
            return this.CanExecute();
        }

        void ICommand.Execute(object? parameter)
        {
            this.Execute();
        }

        void IRelayCommand.NotifyCanExecuteChanged()
        {
            this.internalCanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <returns><c>true</c> if this command can be executed, otherwise, <c>false</c>.</returns>
        protected abstract bool CanExecute();

        /// <summary>
        /// Executes the command.
        /// </summary>
        protected abstract void Execute();

        #endregion
    }
}
