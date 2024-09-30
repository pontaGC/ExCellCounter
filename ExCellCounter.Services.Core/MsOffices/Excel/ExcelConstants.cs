namespace ExCellCounter.Services.Core.MsOffices.Excel;

/// <summary>
/// Excel constants.
/// </summary>
public static class ExcelConstants
{
    public const int MinSheetNameLength = 1;
    public const int MaxSheetNameLength = 31;

    /// <summary>
    /// Gets the illegal worksheet name characters.
    /// </summary>
    public static readonly IReadOnlyCollection<char> IllegalWorksheetNameChars = "\0\u0003:\\/?*[]".ToCharArray();
}
