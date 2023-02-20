namespace SimpleMarsRover.Logging
{
    internal class FileLog : ILogType
    {
        private string filePath;

        public FileLog(string filePath)
        {
            this.filePath = filePath;
        }
        public void Log(string msj)
        {
            File.AppendAllText(filePath, msj);
        }

        public string ReadAll()
        {
            if(File.Exists(filePath))
                return File.ReadAllText(filePath);
            
            return string.Empty;
        }

        public void Clean()
        {
            File.Delete(filePath);
        }
    }   
}