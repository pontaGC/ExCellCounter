using Maui.DataGrid;

namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// Interaction logic for <see cref="CellCounterSettingView"/>.xaml.
/// </summary>
internal partial class CellCounterSettingView
{
	public CellCounterSettingView()
	{
		InitializeComponent();
	}

    private void OnSelectRowButtonClicked(object sender, EventArgs e)
    {
		if (sender is not Button selectRowButton)
		{
			return;
		}

        this.CounterCellDataGrid.SelectedItem = selectRowButton.BindingContext;
    }
}