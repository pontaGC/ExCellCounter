namespace ExCellCounter.Services.MsOffices.Excel
{
    /// <summary>
    /// Constant parameter for ClosedXML.
    /// </summary>
    internal static class ClosedXmlConstants
    {
        /// <summary>
        /// Gets a collection of the EXCEL file extension that supports ClosedXML.
        /// </summary>
        internal static readonly IReadOnlyCollection<string> SupportedFileExtensions = new[] { ".xlsx", ".xlsm" };
    }
}
