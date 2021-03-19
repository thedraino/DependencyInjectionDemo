using System;
using DemoLibrary.Utilities;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private ILogger _logger;
        private IDataAccess _dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            _logger.Log("Started the processsing of data");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed data");
            _logger.Log("Finished processing of the data");
        }
    }
}
