namespace AWebsite.DataReaders
{
    public interface IDataRequest
    {
        /// <summary>
        /// Used to read data
        /// </summary>
        /// <returns>All the data as a string</returns>
        string RequestData();
    }
}
