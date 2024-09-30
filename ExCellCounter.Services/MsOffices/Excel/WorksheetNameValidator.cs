using ExCellCounter.Services.Core.MsOffices.Excel;

namespace ExCellCounter.Services.MsOffices.Excel;

/// <summary>
/// Responsible for validating a worksheet name in EXCEL.
/// </summary>
internal class WorksheetNameValidator : IWorksheetNameValidator
{
    #region Public Methods

    /// <inheritdoc />
    public bool Validate(string sheetName)
    {
        if (!this.IsValidNameLength(sheetName))
        {
            return false;
        }

        if (!this.ContainsOnlyValidChars(sheetName))
        {
            return false;
        }

        if (!this.StartsAndEndsWithoutApostrophe(sheetName))
        {
            return false;
        }

        return true;
    }

    /// <inheritdoc />
    public bool IsValidNameLength(string sheetName)
    {
        if (string.IsNullOrEmpty(sheetName))
        {
            return false;
        }

        int nameLength = sheetName.Trim().Length;
        return nameLength <= ExcelConstants.MaxSheetNameLength; 
    }

    /// <inheritdoc />
    public bool ContainsOnlyValidChars(string sheetName)
    {
        if (sheetName is null)
        {
            // NULL is not considered invalid in this method
            return false;
        }

        foreach(var nameChar in sheetName)
        {
            if (ExcelConstants.IllegalWorksheetNameChars.Contains(nameChar))
            {
                return false;
            }
        }

        return true;
    }

    /// <inheritdoc />
    public bool StartsAndEndsWithoutApostrophe(string sheetName)
    {
        const char Apostrophe = '\'';

        if (sheetName is null)
        {
            // NULL is not considered invalid in this method
            return false;
        }

        int lastCharIndex = sheetName.Length - 1;
        return sheetName[0] != Apostrophe && sheetName[lastCharIndex] != Apostrophe;
    }

    #endregion
}
