using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public enum Direction
    {
        stopped,
        up,
        down
    }

    public enum Urgency
    {
        Low,
        Normal,
        High,
        Extreme
    }
    public class Stop
    {
        public int Floor;
        public Direction NextDirection; 
    }

    public class Floor
    {
        public List<Stop> Stops;
        public int FloorNumber;
    }

    public class Request
    {
        public int Floor;
        public Elavator Elavator;
        public Direction Direction;
        public Urgency Urgency;
    }

    class Elavator
    {
        public int Capacity;
        public Direction CurrentDirection;
        public List<Stop> Stops;
        public List<Request> Requests;

        public bool MoveToNextStop();
        public bool TakeNewRequest();
        public bool CreateRequest();
    }

    class Building
    {
        public List<Stop> Stops;
        public List<Elavator> Elavators;

        public bool DispatchRequest(Request request);
    }
}
