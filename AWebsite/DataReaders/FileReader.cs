using System;
using System.IO;

namespace AWebsite.DataReaders
{
    public class FileReader : IDataRequest
    {
        public FileReader(string path = "")
        {
            Path = path;
        }

        public string Path { get; set; } 

        public string RequestData()
        {
            return ReadFile();
        }

        /// <summary>
        /// Used to all file data from path
        /// </summary>
        /// <returns>All file data as a string</returns>
        private string ReadFile()
        {
            try
            {
                // Opens file
                StreamReader inFile = new StreamReader(Path);

                // Reads all the data in the file
                string data = inFile.ReadToEnd();

                return data;
            }
            catch (Exception ex)
            {
                return $"Error couldn't read file {Path} : {ex.Message}";
            }
        }
    }
}
