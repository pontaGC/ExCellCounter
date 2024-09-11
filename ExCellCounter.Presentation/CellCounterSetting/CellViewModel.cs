using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The view-model for a cell to be counted.
/// </summary>
internal class CellViewModel : ViewModelBase
{
    #region Fields

    private string column = string.Empty;
    private string? name = string.Empty;
    private string row = string.Empty;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a column value of the cell address.
    /// </summary>
    public string Column
    {
        get => this.column;
        set => this.SetProperty(ref this.column, value);
    }

    /// <summary>
    /// Gets or sets a row value of the cell address.
    /// </summary>
    public string Row
    {
        get => this.row;
        set => this.SetProperty(ref this.row, value);
    }

    /// <summary>
    /// Gets or sets a name of the cell. Can be <c>null</c>.
    /// </summary>
    public string? Name
    {
        get => this.name;
        set => this.SetProperty(ref this.name, value);
    }

    #endregion
}
