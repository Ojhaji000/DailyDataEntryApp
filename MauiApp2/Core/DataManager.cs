namespace DailyDataEntryApp.Core
{
    internal class DataManager
    {
        public static bool MakeDataEntry(string name, string depositType, float amount, DateTime date)
        {
            if (!JsonManager.FilePresentLocally())
            {
                //if (!CSVManager.FilePresentinDrive())
                //{
                //    CSVManager.CreateFileLocally();
                //}
                //else
                //{
                //    //CSVManager.FileDownload();
                //}                
                JsonManager.CreateFileLocally();
            }
            JsonManager.AddData(name, depositType, amount, date);
            return false;
        }
    }
}
