namespace DailyDataEntryApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoDownloadPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DownloadPage());
        }

        private async void GoDataEntryPageBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataEntryPage());
        }
    }

}
