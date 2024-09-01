using ExCellCounter.Presentation.Core.Factories;
using ExCellCounter.Presentation.MainPageView;

namespace ExCellCounter.Presentation.Factories
{
    /// <inheritdoc />
    public sealed class MainPageFactory : IMainPageFactory
    {
        /// <inheritdoc />
        public ShellContent Create()
        {
            var contentView = CreateMainPage();
            return new ShellContent()
            {
                Title = contentView.Title,
                Content = contentView,
                Route = "MainPage",
            };
        }

        private MainPage CreateMainPage()
        {
            return new MainPage()
            {
                Title = "Home",
            };
        }
    }
}
