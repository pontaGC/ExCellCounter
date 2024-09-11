using ExCellCounter.Presentation.CellCounterSetting;
using ExCellCounter.Presentation.Core.Mvvm;

namespace ExCellCounter.Presentation.MainPageView;

/// <summary>
/// The view-model for main page.
/// </summary>
internal class MainPageViewModel : ViewModelBase
{
    /// <summary>
    /// Initializes a new instance of <see cref="MainPageViewModel"/> class.
    /// </summary>
    public MainPageViewModel()
    {
        this.CellCounterSetting = new CellCounterSettingViewModel();
    }
    
    /// <summary>
    /// Gets a cell counter setting view-model.
    /// </summary>
    public CellCounterSettingViewModel CellCounterSetting { get; }
}
