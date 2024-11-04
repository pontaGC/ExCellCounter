namespace ExCellCounter.Presentation.CellCounterSetting;

/// <summary>
/// Interaction logic for <see cref="CellCounterSettingTextField"/>.xaml.
/// </summary>
internal partial class CellCounterSettingTextField
{

    #region Bindibale Properties

    public static readonly BindableProperty TextProperty
        = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(CellCounterSettingTextField),
            string.Empty,
            BindingMode.TwoWay,
            propertyChanged: OnTextChanged);

    public static readonly BindableProperty HasErrorProperty
        = BindableProperty.Create(
            nameof(HasError),
            typeof(bool),
            typeof(CellCounterSettingTextField),
            false,
            BindingMode.OneWay);

    public static readonly BindableProperty ErrorsProperty
        = BindableProperty.Create(
            nameof(Errors),
            typeof(IEnumerable<string>),
            typeof(CellCounterSettingTextField),
            Enumerable.Empty<string>(),
            BindingMode.OneWay);

    #endregion

    #region Constructors

    public CellCounterSettingTextField()
	{
		InitializeComponent();
	}

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets a text in field.
    /// </summary>
    public string Text
    {
        get => (string)this.GetValue(TextProperty);
        set => this.SetValue(TextProperty, value);
    }

    /// <summary>
    /// Gets or sets a value indicating errors occurs.
    /// </summary>
    public bool HasError
    {
        get => (bool)this.GetValue(HasErrorProperty);
        set => this.SetValue(HasErrorProperty, value);
    }

    /// <summary>
    /// Gets or sets all error message.
    /// </summary>
    public IEnumerable<string> Errors
    {
        get => (IEnumerable<string>)this.GetValue(ErrorsProperty);
        set => this.SetValue(ErrorsProperty, value ?? Enumerable.Empty<string>());
    }

    #endregion

    #region Private Methods

    private static void OnTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not CellCounterSettingTextField self)
        {
            return;
        }

        if (oldValue is not string oldText || newValue is not string newText)
        {
            return;
        }

        if (oldText == newText)
        {
            // Not need to update
            return;
        }

        self.FieldEntry.Text = newText;
        self.ErrorContentLabel.Text = self.Errors.FirstOrDefault();
        self.ErrorContentLabel.IsVisible = self.HasError;
    }

    private void FieldEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        this.Text = e.NewTextValue;
    }

    #endregion
}