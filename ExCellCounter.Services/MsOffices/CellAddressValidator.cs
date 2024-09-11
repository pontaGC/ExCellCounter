using ClosedXML.Excel;
using ExCellCounter.Services.Core.MsOffices;

namespace ExCellCounter.Services.MsOffices;

/// <summary>
/// 
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
