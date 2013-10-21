using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusAroundMe
{
    public class DataAccessService
    {
        private static RestXmlDataService restDataAccessService = new RestXmlDataService();
        //private static MockDataService.MockDataAccessService mockDataAccessService = new MockDataService.MockDataAccessService();
        //private static XmlDesDataService xmlDeserializationService = new XmlDesDataService();

        public static IDataAccessService CurrentDataService
        {
            get
            {
                return restDataAccessService;
            }
        }
    }
}
