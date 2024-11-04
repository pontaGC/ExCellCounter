using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The view-model for displaying the relationship between worksheets and cells in a flat manner.
/// </summary>
internal class WorksheetCellViewModel : ViewModelBase
{
    #region Properties

    /// <summary>
    /// Gets or sets a name of worksheet.
    /// </summary>
    public ValidatableObserveProperty<string> SheetName { get; } = new ValidatableObserveProperty<string>();

    /// <summary>
    /// Gets or sets a cell address (e.g. AZ10, D2).
    /// </summary>
    public ValidatableObserveProperty<string> CellAddress { get; } = new ValidatableObserveProperty<string>();

    /// <summary>
    /// Gets or sets a label of the cell.
    /// </summary>
    public ValidatableObserveProperty<string> CellLabel { get; } = new ValidatableObserveProperty<string>();

    #endregion
}
