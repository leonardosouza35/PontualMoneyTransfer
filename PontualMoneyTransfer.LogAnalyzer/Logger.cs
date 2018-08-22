using System.Collections.Generic;

namespace PontualMoneyTransfer.LogAnalyzer
{
    public class Logger
    {
        private string _fullFilePath;
        public Logger(string fullFilePath)
        {
            _fullFilePath = fullFilePath;
        }

        public void Write(List<string> lines)
        {
            foreach(var line in lines)
            {                                    
                System.IO.File.AppendAllText(_fullFilePath, $"{line},{System.Environment.NewLine}");                
            }
        }
    }
}