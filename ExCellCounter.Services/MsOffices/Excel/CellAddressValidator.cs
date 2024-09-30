using ClosedXML.Excel;
using ExCellCounter.Services.Core.MsOffices.Excel;

namespace ExCellCounter.Services.MsOffices.Excel;

/// <summary>
/// Responsible for validating a cell address in EXCEL.
/// </summary>
internal sealed class CellAddressValidator : ICellAddressValidator
{
    #region Public Methods

    /// <inheritdoc />
    public bool Validate(string cellAddress)
    {
        // Returns false if the cell address is null or an empty string.
        return XLHelper.IsValidA1Address(cellAddress);
    }

    #endregion
}
