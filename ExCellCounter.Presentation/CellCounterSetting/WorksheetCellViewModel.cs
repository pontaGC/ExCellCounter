using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The view-model for displaying the relationship between worksheets and cells in a flat manner.
/// </summary>
internal class WorksheetCellViewModel : ViewModelBase
{
    #region Fields

    private string cellAddress = string.Empty;
    private string cellLabel = string.Empty;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a name of worksheet.
    /// </summary>
    public ValidatableObserveProperty<string> SheetName { get; } = new ValidatableObserveProperty<string>();

    /// <summary>
    /// Gets or sets a cell address (e.g. AZ10, D2).
    /// </summary>
    public string CellAddress
    {
        get => this.cellAddress;
        set => this.SetProperty(ref this.cellAddress, value ?? string.Empty);
    }

    /// <summary>
    /// Gets or sets a label of the cell.
    /// </summary>
    public string CellLabel
    {
        get => this.cellLabel;
        set => this.SetProperty(ref this.cellLabel, value ?? string.Empty);
    }

    #endregion
}
