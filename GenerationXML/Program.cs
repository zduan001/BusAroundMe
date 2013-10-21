using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationXML
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoutesTableAdapters.SpGetBusRoutesAtAStopTableAdapter busRoutesAdapter = new BusRoutesTableAdapters.SpGetBusRoutesAtAStopTableAdapter();
            busRoutesAdapter.GetData().WriteXml("BusRoutes.xml");

            CurrentTimeTableAdapters.CurrentTimeTableAdapter timeAdapter = new CurrentTimeTableAdapters.CurrentTimeTableAdapter();
            timeAdapter.GetData().WriteXml("CurrenTime.xml");

            BusStopsTableAdapters.BusStopTableAdapter busStopAdapter = new BusStopsTableAdapters.BusStopTableAdapter();
            busStopAdapter.GetData().WriteXml("BusStops.xml");

            AgencyTableAdapters.AgencyTableAdapter agencyAdapter = new AgencyTableAdapters.AgencyTableAdapter();
            agencyAdapter.GetData().WriteXml("Agency.xml");

            ArrivalDeparturesTableAdapters.SpGetArrivalAndDeparturesTableAdapter arrivaleDepartureAdapter = new ArrivalDeparturesTableAdapters.SpGetArrivalAndDeparturesTableAdapter();
            arrivaleDepartureAdapter.GetData().WriteXml("ArrivalDepartureAdapter.xml");
        }
    }
}
