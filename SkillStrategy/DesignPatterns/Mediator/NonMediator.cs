using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.NonMediator
{
    public abstract class Aircraft
    {
        private int _currentAltitude;
        protected IList<Aircraft> _acknowledgeAircraft = new List<Aircraft>();
        private string CallSign {get;set;}
        public abstract int Ceiling { get; }
        public abstract bool IsTrailingGapAcceptable();
        public int Altitude
        {
            get { return _currentAltitude; }
        }

        protected Aircraft(string callSign)
        {
            CallSign = callSign;
        }

        public void Acknowledges(Aircraft airCraft)
        {
            _acknowledgeAircraft.Add(airCraft);
        }
    }

    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign)
            : base(callSign)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }

        public override bool IsTrailingGapAcceptable()
        {
            foreach (var acknowledgeAircraft in _acknowledgeAircraft)
            {
                if (acknowledgeAircraft.GetType() == typeof(Boeing737200))
                {
                }
                if (acknowledgeAircraft.GetType() == typeof(Embraer190))
                {
                }
            }

            return false;
        }
    }

    class Boeing737200
    {
    }

    class Embraer190
    {
    }
}
