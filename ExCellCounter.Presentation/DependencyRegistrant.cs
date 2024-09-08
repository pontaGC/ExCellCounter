using ExCellCounter.Presentation.Core.Factories;
using ExCellCounter.Presentation.Factories;
using ExCellCounter.Shared.DependencyInjection;

namespace ExCellCounter.Presentation;

/// <inheritdoc />
public sealed class DependencyRegistrant : IDependenyRegistrant
{
    /// <inheritdoc />
    public void Register(IServiceCollection container)
    {
        ArgumentNullException.ThrowIfNull(container);

        RegisterFactories(container);
    }

    private static void RegisterFactories(IServiceCollection container)
    {
        container.AddSingleton<IMainPageFactory, MainPageFactory>();
    }
}
