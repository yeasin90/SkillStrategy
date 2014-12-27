using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqPractice;
using System.Collections.Generic;

namespace MoqPractice.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void the_respository_save_should_be_called()
        {
            // Arrange
            var mockRepository = new Mock<ICustomerRepository>();

            // This setup means : we expect this method only to be called and we don't care about the parameters. We just wanna make sure it's get called
            mockRepository.Setup(x => x.Save(
                It.IsAny<Customer>() // Read as, It is for Any Customer. Or for any customer. Because we only want this method to be called for any parameter
                ));

            var customerService = new CustomerService(mockRepository.Object);

            // Act
            customerService.Create(new CustomerToCreateDto());

            // Assert
            // VerifyAll() = everything we have done in the arrange area as a setup should be checked to see if it occured
            // Example : if we comment out the repostiory Save method from SUT, this unit test will throw exception, because VerifyAll will fail
            mockRepository.VerifyAll();
        }

        // Simple verification of SUT
        // -> Assert succeded?
        // -> Did a method get called?
        // -> How many times did it get called?
        // -> Did the method did not get called at all?
        [TestMethod]
        public void the_customer_repositry_should_be_called_once_per_customer()
        {
            // Arrange
            var listOfCustomerDtos = new List<CustomerToCreateDto>
            {
                new CustomerToCreateDto { FirstName = "Yeasin", LastName = "Abedin" },
                new CustomerToCreateDto { FirstName = "Sheikh", LastName = "Jubair" },
                new CustomerToCreateDto { FirstName = "Touhid", LastName = "Alam" }
            };

            var mockRepository = new Mock<ICustomerRepository>();
            mockRepository.Setup(x => x.Save(It.IsAny<Customer>()));

            //This line is called SUT (System under test)
            var customerService = new CustomerService(mockRepository.Object); // .Object use na korle, <T> pass hoe. .Object use korle <T> = <ICustomerRepository> type e convert hobe

            // Act or Execut the SUT
            customerService.Create(listOfCustomerDtos);

            // Assert
            mockRepository.Verify(); // We expected that repo.Save() should be called. Could be called once or thousand time. We just making sure it's getting called
            mockRepository.Verify(x => x.Save(It.IsAny<Customer>()),
                Times.Exactly(listOfCustomerDtos.Count)); // repo.Save() has to be called excatly the same number of times the collection count

            // This assert will fail. Will display : Expected invocation on the mock exactly 2 times, but it was 3(list count) times: x => x.Save(It.IsAny<Customer>())
            mockRepository.Verify(x => x.Save(It.IsAny<Customer>()),
                Times.Exactly(2));

            // There are various overloads of Verify()
            mockRepository.Verify(x => x.Save(It.IsAny<Customer>()), "");
            mockRepository.Verify(x => x.Save(It.IsAny<Customer>()), Times.AtLeast(2));
            // etc
        }

        // Return values of mocked or faked objects
        // Return values from
        // -> Function call
        // -> out parameters
        // -> ref parameters
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void an_exception_should_be_thrown_if_the_address_is_not_created()
        {
            // Arrange
            var customerToCreateDto = new CustomerToCreateDto { FirstName = "Yeasin", LastName = "Abedin" };

            var mockRepository = new Mock<ICustomerRepository>();
            var mockAdderssBuilder = new Mock<ICustomerAddressBuilder>();

            // mockAdderssBuilder.From(customerToCreateDto) ke Setup er maddhome Return type define kore dea hoe nai.
            // By default inside Moq, if we don't define what is going to return, it will retunr the default value
            // Example : 
            // mockAdderssBuilder.Setup(x => x.From(It.IsAny<CustomerToCreateDto>())).Returns(() => null);
            // aivabe amra setup kore Return type define kore dite partam.
            // but jehetu ei setup amra kori nai, so mock object or mockAdderssBuilder er Form() method will return default value.
            // and default value of Address or Object is null. So _customerAddressBuilder.From(customerToCreateDto) will return NULL.
            // So retunr type int thakle default is 0 etc etc

            // Explicitly define korle
            mockAdderssBuilder
                .Setup(x => x.From(It.IsAny<CustomerToCreateDto>()))
                .Returns(() => null); // Like setup, everything is going to be handled using lambda. (this will not be like .Returns(null) )
            // () => means a ZERO parameter will pass in and will return a NULL

            var customerService = new CustomerService(
                mockRepository.Object,
                mockAdderssBuilder.Object);

            // Act
            customerService.Create2(customerToCreateDto);

            // Assert
        }

        [TestMethod]
        public void the_customer_should_be_saved_if_the_addres_was_created()
        {
            // Arrange
            var customerToCreateDto = new CustomerToCreateDto { FirstName = "Yeasin", LastName = "Abedin" };
            var mockRepository = new Mock<ICustomerRepository>();
            var mockAddressBuilder = new Mock<ICustomerAddressBuilder>();

            mockAddressBuilder
                .Setup(x => x.From(It.IsAny<CustomerToCreateDto>()))
                .Returns(new Address());
            //mockRepository.Setup(x => x.Save(It.IsAny<Customer>()));

            var customerService = new CustomerService(
                mockRepository.Object,
                mockAddressBuilder.Object
                );

            // Act
            customerService.Create2(customerToCreateDto);

            // Assert
            mockRepository.Verify(y => y.Save(It.IsAny<Customer>()));
            // In the arrange, if we used : 
            // mockRepository.Setup(x => x.Save(It.IsAny<Customer>())); , then in Assert, we could use : 
            // mockRepository.VerifyAll() . This is becuase we have already made the setup for Save(). we now just need to verify all.
        }

        [TestMethod]
        public void each_customer_should_be_assigned_an_id()
        {
            // Arrange
            var listOfCustomersToCreate = new List<CustomerToCreateDto>
                                            {
                                                new CustomerToCreateDto(),
                                                new CustomerToCreateDto()
                                            };

            var mockRepository = new Mock<ICustomerRepository>();
            var mockIdFactory = new Mock<IIdFactory>();

            var i = 1;
            mockIdFactory.Setup(x => x.Creeate())
                .Returns(() => i) // Return value for the first time it's being called
                .Callback(() => i++); // This setup is to ensure that mock object is getting called everytime with a different

            var customerService = new CustomerService(
                mockRepository.Object,
                mockIdFactory.Object
                );

            // Act
            customerService.Create3(listOfCustomersToCreate);

            // Assert
            mockIdFactory.Verify(x => x.Creeate(), Times.AtLeastOnce());
        }

        // Arguments of mock objects
        // -> verifying what value was passed
        // -> different behaviours for different method parameters
        // -> can be used to help control SUT execution flow
        [TestMethod]
        public void a_full_name_should_be_created_from_first_and_last_name()
        {
            //Arrange
            var customerToCreateDto = new CustomerToCreateDto
                                        {
                                            FirstName = "Yeasin",
                                            LastName = "Abedin"
                                        };

            var mockRepository = new Mock<ICustomerRepository>();
            var mockFullNameBuilder = new Mock<ICustomerFullNameBuilder>();

            // This setup means : we expect this method only to be called and we don't care about the parameters. We just wanna make sure it's get called
            mockFullNameBuilder.Setup(
                x => x.From(It.IsAny<string>(), It.IsAny<string>()));

            var customerService = new CustomerService(
                mockRepository.Object, mockFullNameBuilder.Object);

            //Act
            customerService.Create4(customerToCreateDto);

            //Assert
            // Test kortesi, mock er or _customerFullName.From( method only customerToCreateDto er FIrstName and LastName nae kina...onno kichu nile test case fail
            mockFullNameBuilder.Verify(x => x.From(
                It.Is<string>( // Read as It Is a <string> and that <string> is going to be () define within this
                fn => fn.Equals(customerToCreateDto.FirstName, StringComparison.InvariantCultureIgnoreCase)
                ),
                It.Is<string>( // Read as It Is a <string> and that <string> is going to be () define within this
                fn => fn.Equals(customerToCreateDto.LastName, StringComparison.InvariantCultureIgnoreCase)
                )
            ));

            // *VVI Note
            //***Now jodi main function er :
            // _customerFullName.From(
              //  customerToCreateDto.FirstName,
               // customerToCreateDto.LastName)
            // er bodole : 
            // _customerFullName.From(
            //  "abcd",
            // customerToCreateDto.LastName)
            // tahole, ei test case fail korbe. Cuz amra assert e bole disi only work for Paramaeters that are passed in from CustomerTOCreateDto object
        }

        // Argument and Execution flow control
        [TestMethod]
        public void a_special_save_routine_should_be_used()
        {
            //Arrange
            var mockRepository = new Mock<ICustomerRepository>();
            var mockStatusFactory = new Mock<ICustomerStatusFactory>();

            var customerToCreate = new CustomerToCreateDto
                                    {
                                        DesiredStatus = CustomerStatus.Platinum, // if DesiredStatus = CustomerStatus.Gold, this will fail because 
                                        FirstName = "Yeasin",                    // in our setup we have defined that we should return a Status Platinum when our 
                                        LastName = "Abedin"                      // DesiredStatus Status is Platinum or It.Is<CustomerToCreateDto> 's DesiredStatus is Platinum
                                    };                                           // So, if we dclared DesiredStatus = CustomerStatus.Gold, this case will fail.

            //************** VVI **********//
            //mockStatusFactory.Setup(x => x.CreateFrom(customerToCreate));
            // If we done this above Setup, status factory will return the defualt value, which is Gold
            // As a result, our test case will fail becuase in our assert we are verifying SaveSpcial method
            

            // if else like mock setup
            mockStatusFactory.Setup(
                x => x.CreateFrom(
                    It.Is<CustomerToCreateDto>(
                    y => y.DesiredStatus == CustomerStatus.Platinum)))
                .Returns(CustomerStatus.Platinum);
            // Here we are saying that
            // If It.Is< a CusotmerToCreateDto (specific one that we have declare in arrange
            // and if that types Desired status is Platinum
            // then _customerStatusFactory.CreateFrom will return Platinum

            var customerService = new CustomerService(
                mockRepository.Object, mockStatusFactory.Object);

            //Act
            customerService.Create5(customerToCreate);

            //Assert
            // To verfiy if the SaveSpecial is run.
            // But in order to SaveSpcial to run, the _customerStatusFactory.CreateFrom must return a status of Platinum
            mockRepository.Verify(
                x => x.SaveSpecial(It.IsAny<Customer>()));

            ///**** VVII ******
            // Summary : If we want to pass a declare Object or an Object that we have eplicitly defined in our Arrange, use It.Is<>
            //           If we don't care about the parameter, we ant the function only to be executed, use It.IsAny<>
        }

        // Mocking Properties
        // -> Verify setter calls or verify that a value has been set to a property
        // -> Verify Return values from getter calls
        [TestMethod]
        public void the_local_timezone_should_be_set()
        {
            //Arrange
            var mockRepository = new Mock<ICustomerRepository>();

            var customerService = new CustomerService(
                mockRepository.Object);

            //Act
            customerService.Create6(new CustomerToCreateDto());

            //Assert
            // Here we wanna test that the LocalTimeZone variale is really getting set.
            mockRepository.VerifySet(
                x => x.LocalTimeZone = It.IsAny<string>());

            //*******VVI***************
            // if we comment out :
            // _customerRepository.LocalTimeZone = TimeZone.CurrentTimeZone.StandardName;
            // the above line from the main SUT, then this case will fail because we are verifying that whether the LocalTimeZone is being set or not  
        }

        // Testing getter
        [TestMethod]
        public void the_workstation_id_should_be_used()
        {
            //Arrange
            var mockRepository = new Mock<ICustomerRepository>();
            var mockApplicationSettings = new Mock<IApplicationSettings>();

            //mockApplicationSettings.Setup(x => x.WorkStationId)
            //if we do the above Setup, _applicationSettings.WorkStationId will return it's default value which is NULL 

            mockApplicationSettings.Setup(x => x.WorkStationId).Returns(new DateTime());

            var customerService = new CustomerService(
                mockRepository.Object, mockApplicationSettings.Object);

            //Act
            customerService.Create7(new CustomerToCreateDto());

            //Assert
            // Verify that the _applicationSettings.WorkStationId is actually being called
            mockApplicationSettings.VerifyGet(x => x.WorkStationId);

            //*** VVI****
            // if we comment the following line from SUT
            // _applicationSettings.WorkStationId;
            // then this case will fail, because there was no Invokation of _applicationSettings.WorkStationId
        }

        // Stubbing properties
        // BEFORE THIS, STUDY DIFFERENCE BETWEEN MOCK AND STUB :
        // Link : http://sevennet.org/2014/12/24/how-to-what-are-the-differences-between-mocks-and-stubs-on-rhino-mocks/
        //A mock is an object that we can set expectations on, and which will verify that the expected actions have indeed occurred. 
        //A stub is an object that you use in order to pass to the code under test. 
        //You can setup expectations on it, so it would act in certain ways, but those expectations will never be verified. 
        //A stub’s properties will automatically behave like normal properties, and you can’t set expectations on them.
        //If you want to verify the behavior of the code under test, you will use a mock with the appropriate expectation, and verify that. 
        //If you want just to pass a value that may need to act in a certain way, but isn’t the focus of this test, you will use a stub.

        //IMPORTANT: A stub will never cause a test to fail.

        // Now study Pluralsight : Pluralsight\Pluralsight Software Practices\Mocking With Moq\4. Mocking with Moq\19 and 20
    }
}
