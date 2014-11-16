using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MyMediator
{
    public abstract class Car
    {
        public abstract string Name { get; }
        public abstract string Color { get; }
        protected readonly IMediator _mediator;

        public Car(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterColleauges(this);
        }
    }

    public class BMW : Car
    {
        public override string Name { get { return "BMW"; } }
        public override string Color { get { return "Blue"; } }
        public int Price
        {
            set
            {
                _mediator.Notify(this);
            }
        }

        public BMW(IMediator mediator)
            : base(mediator)
        {
        }
    }

    public class Audi : Car
    {
        public override string Name { get { return "Audi"; } }
        public override string Color { get { return "White"; } }

        public Audi(IMediator mediator)
            : base(mediator)
        {
        }
    }

    public interface IMediator
    {
        void RegisterColleauges(Car car);
        void Notify(Car reportingCar);
    }

    public class Mediator : IMediator
    {
        private readonly List<Car> _carsUnderGuidance = new List<Car>();

        public void RegisterColleauges(Car car)
        {
            Console.WriteLine(car.Name);
            if (!_carsUnderGuidance.Contains(car))
                _carsUnderGuidance.Add(car);
        }

        public void Notify(Car reportingCar)
        {
            if (reportingCar is BMW)
            {
                var reportTO = _carsUnderGuidance.Where(x => x is Audi).FirstOrDefault();
            }
        }
    }

}
