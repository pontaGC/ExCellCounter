namespace ExCellCounter.Services.Core.MsOffices.Excel;

/// <summary>
/// Responsible for validating a worksheet name in EXCEL.
/// </summary>
public interface IWorksheetNameValidator
{
    /// <summary>
    /// Validates the given worksheet name.
    /// </summary>
    /// <param name="sheetName">The name of worksheet to check).</param>
    /// <returns><c>true</c> if <paramref name="sheetName"/> is not empty and valid, otherwise, <c>false</c>.</returns>
    /// <remarks>This is verified by executing other verification methods in <see cref="IWorksheetNameValidator"/>.</remarks>
    bool Validate(string sheetName);

    /// <summary>
    /// Checks whether the length of the given worksheet name is within the valid range or not.
    /// For the valid range of name length, see <see cref="ExcelConstants"/>.
    /// </summary>
    /// <param name="sheetName">The name of worksheet to check).</param>
    /// <returns><c>true</c> if the length of <paramref name="sheetName"/> is within the valid range, otherwise, <c>false</c>.</returns>
    bool IsValidNameLength(string sheetName);

    /// <summary>
    /// Checks whether the given worksheet name contains the illegal character or not.
    /// For the illegal characters, see <see cref="ExcelConstants"/>.
    /// </summary>
    /// <param name="sheetName">The name of worksheet to check).</param>
    /// <returns><c>true</c> if the <paramref name="sheetName"/> does not contain the illegal character, otherwise, <c>false</c>.</returns>
    bool ContainsOnlyValidChars(string sheetName);

    /// <summary>
    /// Checks whether the given worksheet name does not start or end with apostrophe (').
    /// </summary>
    /// <param name="sheetName">The name of worksheet to check).</param>
    /// <returns><c>true</c> if the <paramref name="sheetName"/> does not start or end with apostrophe, otherwise, <c>false</c>.</returns>
    bool StartsAndEndsWithoutApostrophe(string sheetName);
}
