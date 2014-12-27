using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPractice
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerAddressBuilder _customerAddressBuilder;
        private readonly IIdFactory _idFactory;
        private readonly ICustomerFullNameBuilder _customerFullName;
        private readonly ICustomerStatusFactory _customerStatusFactory;
        private readonly IApplicationSettings _applicationSettings;

        #region Overloaded Constructors
        public CustomerService(ICustomerRepository customerRepository, ICustomerAddressBuilder customerAddressBuilder)
        {
            _customerRepository = customerRepository;
            _customerAddressBuilder = customerAddressBuilder;
        }

        public CustomerService(ICustomerRepository customerRepository, IIdFactory idFactory)
        {
            _customerRepository = customerRepository;
            _idFactory = idFactory;
        }

        public CustomerService(ICustomerRepository customerRepository, ICustomerFullNameBuilder customerFullName)
        {
            _customerRepository = customerRepository;
            _customerFullName = customerFullName;
        }

        public CustomerService(ICustomerRepository customerRepository, ICustomerStatusFactory customerStatusFactory)
        {
            _customerRepository = customerRepository;
            _customerStatusFactory = customerStatusFactory;
        }

        public CustomerService(ICustomerRepository customerRepository, IApplicationSettings applicationSettings)
        {
            _customerRepository = customerRepository;
            _applicationSettings = applicationSettings;
        }

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        #endregion

        public void Create(CustomerToCreateDto customerToCreateDto)
        {
            var customer = BuildCustomerObjectFrom(customerToCreateDto);

            _customerRepository.Save(customer);
        }

        public void Create(IEnumerable<CustomerToCreateDto> customersToCreate)
        {
            foreach (var customerToCreateDto in customersToCreate)
            {
                _customerRepository.Save(
                    new Customer(
                        customerToCreateDto.FirstName,
                        customerToCreateDto.LastName)
                   );
            }
        }

        public void Create2(CustomerToCreateDto customerToCreateDto)
        {
            var customer = new Customer(
                   customerToCreateDto.FirstName,
                   customerToCreateDto.LastName);

            customer.MailingAddress = _customerAddressBuilder.From(customerToCreateDto);

            if (customer.MailingAddress == null)
                throw new ArgumentNullException();

            _customerRepository.Save(customer);
        }

        public void Create3(IEnumerable<CustomerToCreateDto> customersToCreate)
        {
            foreach (var customerToCreateDto in customersToCreate)
            {
                var customer = new Customer(
                    customerToCreateDto.FirstName,
                    customerToCreateDto.LastName);

                customer.ID = _idFactory.Creeate();

                _customerRepository.Save(customer);
            }
        }

        public void Create4(CustomerToCreateDto customerToCreateDto)
        {
            var fullName = _customerFullName.From(
                customerToCreateDto.FirstName,
                customerToCreateDto.LastName);

            var customer = new Customer(fullName);

            _customerRepository.Save(customer);
        }

        public void Create5(CustomerToCreateDto customerToCreateDto)
        {
            var customer = new Customer(
                customerToCreateDto.FirstName, customerToCreateDto.LastName);

            customer.StatusLevel = _customerStatusFactory.CreateFrom(customerToCreateDto);

            if (customer.StatusLevel == CustomerStatus.Platinum)
                _customerRepository.SaveSpecial(customer);
            else
                _customerRepository.Save(customer);
        }

        public void Create6(CustomerToCreateDto customerToCreateDto)
        {
            var customer = new Customer(
                customerToCreateDto.FirstName, customerToCreateDto.LastName);

            _customerRepository.LocalTimeZone = TimeZone.CurrentTimeZone.StandardName;

            _customerRepository.Save(customer);
        }

        public void Create7(CustomerToCreateDto customerToCreateDto)
        {
            var customer = new Customer(customerToCreateDto.Name);

            var workstationid = _applicationSettings.WorkStationId;

            if (!workstationid.HasValue)
                throw new ArgumentNullException();

            customer.WorkStationCreatedOn = workstationid.Value;

            _customerRepository.Save(customer);
        }

        private Customer BuildCustomerObjectFrom(CustomerToCreateDto customerToCreateDto)
        {
            return new Customer(customerToCreateDto.Name, customerToCreateDto.City);
        }
    }
}
