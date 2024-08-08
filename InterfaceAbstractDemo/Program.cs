
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

CustomerManager customerManager = new StarbucksCustomerManager(new MenrisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(2008, 8, 27), FirstName = "NailOrkun", LastName = "Şahin", NationalityId = "27706683740", Id = 2 });
Console.ReadLine();
