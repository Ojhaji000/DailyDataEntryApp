namespace DailyDataEntryApp.Core
{
    internal class StaticData
    {
        private static string mJsonFilePath;
        public static void SetJsonFilePath (string csvFilePath)
        {
            mJsonFilePath = csvFilePath;
        }
        public static string GetJsonFilePath() { return mJsonFilePath; }
        public static string CSVFileName = "customer_data.csv";
    }
}
