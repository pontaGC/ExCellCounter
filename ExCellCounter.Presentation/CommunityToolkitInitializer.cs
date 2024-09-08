namespace ExCellCounter.Presentation;

internal class CommunityToolkitInitializer
{
    static CommunityToolkitInitializer()
    {
        // DO NOT REMOVE to resolve CommunityToolkit linker,
        // unitl the following bug is fixed.
        // https://github.com/CommunityToolkit/Maui/issues/1218
        var ignoreMe = typeof(CommunityToolkit.Maui.Views.Expander);
    }
};

