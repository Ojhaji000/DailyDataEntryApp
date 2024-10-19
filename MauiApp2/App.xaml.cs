using DailyDataEntryApp.Core;

namespace DailyDataEntryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            string mainDir = FileSystem.Current.AppDataDirectory;
            StaticData.SetJsonFilePath(mainDir);

        }
    }
}
