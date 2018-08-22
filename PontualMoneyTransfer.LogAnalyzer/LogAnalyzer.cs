using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PontualMoneyTransfer.LogAnalyzer
{
    public class LogAnalyzer
    {
        private readonly string _fileFullPath;
        private StreamReader _reader;
        private List<string> _searchedList;
        public LogAnalyzer(string filePath)
        {
            _fileFullPath = filePath;
            _searchedList = new List<string>();
        }

        /// <summary>
        /// Tell where to start reading en each line
        /// </summary>
        /// <param name="startReading"></param>
        /// <returns></returns>
        public void SearchAll(string startReading, IEnumerable<string> exceptItems)
        {
            //PaymentId:
            try
            {
                _reader = File.OpenText(_fileFullPath);
                string line = string.Empty;
                string searched = string.Empty;
                while(_reader.Peek() > -1)
                {
                    line = _reader.ReadLine();

                    if(line.IndexOf(startReading) != -1)
                    {

                        var start = line.Substring(line.IndexOf(startReading));
                        searched = start.Substring(start.IndexOf(":") + 1).Trim();

                        if (exceptItems.Any())
                        {
                            if (!exceptItems.Any(i => i == searched))
                                _searchedList.Add(searched);                                                            
                        }
                        else
                        {
                            _searchedList.Add(searched);
                        }
                    }

                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tell where to start reading en each line
        /// </summary>
        /// <param name="startReading"></param>
        /// <returns></returns>
        public void SearchAll(string startReading)
        {
            SearchAll(startReading, new List<string>());
        }


        public List<string> AllItemsSearched
        {
            get { return _searchedList; }
        }
    }
}
