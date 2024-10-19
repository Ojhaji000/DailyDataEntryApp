
namespace DailyDataEntryApp.Core
{
    internal class JsonManager
    {
        private static readonly object fileLock = new object();
        public static void CreateFileLocally()
        {
            if (!Directory.Exists(StaticData.GetJsonFilePath()))
            {
                Directory.CreateDirectory(StaticData.GetJsonFilePath());
            }
            string fullFilePath = Path.Combine(StaticData.GetJsonFilePath(), StaticData.CSVFileName);
            lock (fileLock)
            {
                try
                {
                    // Create or overwrite the file with the given filename
                    using (FileStream fs = new FileStream(fullFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        // add headers to empty file
                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            writer.WriteLine("Name,Amount,Reason,Date");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating CSV file: {ex.Message}");
                }
            }
        }
        public static bool FilePresentLocally()
        {
            if (!Directory.Exists(StaticData.GetJsonFilePath()))
            {
                return false;
            }
            string fullFilePath = Path.Combine(StaticData.GetJsonFilePath(), StaticData.CSVFileName);
            bool filePresence = File.Exists(fullFilePath);
            return filePresence;
        }
        public static bool FilePresentinDrive()
        {
            return true;
        }
        public static bool FileDownload()
        {
            return false;
        }
        public static bool AddData(string name, string depositType, float amount, DateTime date)
        {

            return false;
        }
    }
}
