using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;
        private int _currentAltitude;

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            _atc = atc;
            _callSign = callSign;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        public abstract int Ceiling { get; }
        private string _callSign { get; set; }
        
        
        public int Altitude
        {
            get { return _currentAltitude; }
            set
            {
                _currentAltitude = value;
                _atc.ReceiveAircraftLocation(this);
            }
        }

        public override int GetHashCode()
        {
            return _callSign.GetHashCode();
        }

        public void WarnOfAirspaceIntrusionBy(Aircraft reposrtingAircraft)
        {

        }

        internal void Climb(int p)
        {
            
        }
    }

    //colleauge 1
    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }

    //colleauge 2
    public class Embraer190 : Aircraft
    {
        public Embraer190(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }

    //colleauge 3
    public class Boeing737200 : Aircraft
    {
        public Boeing737200(string callSign, IAirTrafficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 35000; }
        }
    }


    public interface IAirTrafficControl
    {
        void RegisterAircraftUnderGuidance(Aircraft aircraft);

        void ReceiveAircraftLocation(Aircraft location);
    }

    public class YytCenter : IAirTrafficControl
    {
        private readonly IList<Aircraft> _aircraftUnderGuidance = new List<Aircraft>();

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidance.Contains(aircraft))
            {
                _aircraftUnderGuidance.Add(aircraft);
            }
        }

        public void ReceiveAircraftLocation(Aircraft reportingAircraft)
        {
            foreach (var currecntAircraftGuidance in _aircraftUnderGuidance.Where(x => x != reportingAircraft))
            {
                if (Math.Abs(currecntAircraftGuidance.Altitude - reportingAircraft.Altitude) == 0)
                {
                    reportingAircraft.Climb(1000);

                    currecntAircraftGuidance.WarnOfAirspaceIntrusionBy(reportingAircraft);
                    //reportingAircraft.
                }
            }
        }
    }

}
