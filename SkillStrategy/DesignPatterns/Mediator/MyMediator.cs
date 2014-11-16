using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MyMediator
{
    public abstract class Car
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        private readonly IMediator _mediator;

        public Car(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterColleauges(this);
        }
    }

    public class BMW : Car
    {
        public override string Name { get; set; }
        public override string Color { get; set; }

        public BMW(IMediator mediator)
            : base(mediator)
        {
        }
    }

    public class Audi : Car
    {
        public override string Name { get; set; }
        public override string Color { get; set; }

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
            if (!_carsUnderGuidance.Contains(car))
                _carsUnderGuidance.Add(car);
        }

        public void Notify(Car reportingCar)
        {
            throw new NotImplementedException();
        }
    }

}
