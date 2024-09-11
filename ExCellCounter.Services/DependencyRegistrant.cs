using ExCellCounter.Services.Core.MsOffices;
using ExCellCounter.Services.MsOffices;

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
    }
}
