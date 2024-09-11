using System.Collections.ObjectModel;

using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The worksheet view-model.
/// </summary>
internal class WorksheetViewModel : ViewModelBase
{
    #region Fields

    private string name = string.Empty;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a name of worksheet.
    /// </summary>
    public string Name
    {
        get => this.name;
        set => this.SetProperty(ref this.name, value);
    }

    /// <summary>
    /// Gets a collection of the cell to be counted.
    /// </summary>
    public ObservableCollection<CellViewModel> Cells { get; } = new ObservableCollection<CellViewModel>();

    #endregion
}
