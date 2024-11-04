using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExCellCounter.Presentation.Core.Mvvm;
using ExCellCounter.Shared.Rules;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// The cell counter setting view-model.
/// </summary>
internal class CellCounterSettingViewModel : ViewModelBase
{
    #region Fields

    private WorksheetCellViewModel selectedCellItem;

    #endregion

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
            CellAddress = "A1",
            Name = "TopCell"
        };
        dummySheet.Cells.Add(dummyCellAddress);
        this.Worksheets.Add(dummySheet);

        var dummySheetCell1 = new WorksheetCellViewModel();
        dummySheetCell1.SheetName.Value = "Sheet1";
        dummySheetCell1.CellAddress.Value = "A1";
        dummySheetCell1.CellLabel.Value = "English";

        var dummySheetCell2 = new WorksheetCellViewModel();
        dummySheetCell2.SheetName.Value = "Sheet2";
        dummySheetCell2.CellAddress.Value = "AZ100";
        dummySheetCell2.CellAddress.Value = "Math";

        this.WorksheetCells.Add(dummySheetCell1);
        this.WorksheetCells.Add(dummySheetCell2);

        var requiredRule = new DelegateRule<string>(
            "RequiredSheetName",
            x => !string.IsNullOrWhiteSpace(x),
            x => "Field is requred");
        dummySheetCell1.SheetName.AddRule(requiredRule);
        dummySheetCell2.SheetName.AddRule(requiredRule);
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets a collection of the worksheet which has cells to be counted.
    /// </summary>
    public ObservableCollection<WorksheetViewModel> Worksheets { get; } = new ObservableCollection<WorksheetViewModel>();

    /// <summary>
    /// Gets or sets the selected cell item.
    /// </summary>
    public WorksheetCellViewModel SelectedCellItem
    {
        get => this.selectedCellItem;
        set => this.SetProperty(ref this.selectedCellItem, value);
    }

    /// <summary>
    /// Gets a collection of the worksheet and cell to be counted.
    /// </summary>
    public ObservableCollection<WorksheetCellViewModel> WorksheetCells { get; } = new ObservableCollection<WorksheetCellViewModel>();

    #endregion
}
