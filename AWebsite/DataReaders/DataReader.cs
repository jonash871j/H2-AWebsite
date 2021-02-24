namespace AWebsite.DataReaders
{
    public class DataReader
    {
        /// <summary>
        /// Used to read data from a data request
        /// </summary>
        /// <returns>All the data as a string</returns>
        public string ReadData(IDataRequest request)
        {
            return request.RequestData();
        }
    }
}
