using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace ExCellCounter.Presentation.Core.Mvvm
{
    /// <summary>
    /// The relay command base.
    /// </summary>
    /// <typeparam name="T">The type of command parameter.</typeparam>
    public abstract class RelayCommandBase<T> : IRelayCommand
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
            return this.CanExecute((T?)parameter);
        }

        void ICommand.Execute(object? parameter)
        {
            this.Execute((T?)parameter);
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
        /// <param name="parameter">The command parameter. Can be <c>null</c>.</param>
        /// <returns><c>true</c> if this command can be executed, otherwise, <c>false</c>.</returns>
        protected abstract bool CanExecute(T? parameter);

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="parameter">The command parameter. Can be <c>null</c>.</param>
        protected abstract void Execute(T? parameter);

        #endregion
    }
}
