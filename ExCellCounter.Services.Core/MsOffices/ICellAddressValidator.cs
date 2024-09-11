namespace ExCellCounter.Services.Core.MsOffices;

/// <summary>
/// Responsible for validating a cell address in EXCEL.
/// </summary>
public interface ICellAddressValidator
{
    /// <summary>
    /// Validates the given cell address.
    /// </summary>
    /// <param name="cellAddress">The cell address to check (e.g. A1).</param>
    /// <returns><c>true</c> if <paramref name="cellAddress"/> is not empty and valid, otherwise, <c>false</c>.</returns>
    bool Validate(string cellAddress);
}
