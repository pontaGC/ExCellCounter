using ExCellCounter.Services.Core.MsOffices.Excel;
using ExCellCounter.Services.MsOffices.Excel;
using ExCellCounter.Shared.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace ExCellCounter.Services;

/// <inheritdoc />
public sealed class DependencyRegistrant : IDependenyRegistrant
{
    /// <inheritdoc />
    public void Register(IServiceCollection container)
    {
        ArgumentNullException.ThrowIfNull(container);

        RegisterMsOffices(container);
    }

    private static void RegisterMsOffices(IServiceCollection container)
    {
        container.AddSingleton<ICellAddressValidator, CellAddressValidator>();
        container.AddSingleton<IWorksheetNameValidator, WorksheetNameValidator>();
    }
}
