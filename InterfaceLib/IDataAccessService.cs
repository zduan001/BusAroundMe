using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace BusAroundMe
{
    public interface IDataAccessService
    {
        Collection<double> DecodePolyline(string polyline);
        Task<List<BusRoute>> GetBusRoutesAtAStop(BusStop stop);
        Task<List<BusStop>> GetBusStopsAtALocation(double latitude, double longitude);
        Task<BusStop> GetDepartureTimeAtStop(string stopId);
        Task<Collection<double>> GetPathForRoute(string routeId);
    }
}
