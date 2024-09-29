using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The view-model for a cell to be counted.
/// </summary>
internal class CellViewModel : ViewModelBase
{
    #region Fields

    private string cellAddress = string.Empty;
    private string name = string.Empty;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a cell address (e.g. AZ10, D2).
    /// </summary>
    public string CellAddress
    {
        get => this.cellAddress;
        set => this.SetProperty(ref this.cellAddress, value ?? string.Empty);
    }

    /// <summary>
    /// Gets or sets a name of the cell.
    /// </summary>
    public string Name
    {
        get => this.name;
        set => this.SetProperty(ref this.name, value ?? string.Empty);
    }

    #endregion
}
