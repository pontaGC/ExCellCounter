using System.Collections.ObjectModel;

using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The cell counter setting view-model.
/// </summary>
internal class CellCounterSettingViewModel : ViewModelBase
{
    #region Constructors

    /// <summary>
    /// Initializes a new instance of <see cref="CellCounterSettingViewModel"/> class.
    /// </summary>
    public CellCounterSettingViewModel()
    {
        var dummySheet = new WorksheetViewModel()
        {
            Name = "Test1",
        };
        var dummyCellAddress = new CellViewModel()
        {
            Row = "A",
            Column = "1",
            Name = "TopCell"
        };
        dummySheet.Cells.Add(dummyCellAddress);
        this.Worksheets.Add(dummySheet);
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets a collection of the worksheet which has cells to be counted.
    /// </summary>
    public ObservableCollection<WorksheetViewModel> Worksheets { get; } = new ObservableCollection<WorksheetViewModel>();

    #endregion
}
