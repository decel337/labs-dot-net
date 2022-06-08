using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace lab1
{
    internal class Program
    {
        private static void Main(string[] args)
    {
      Manufacturer manufacturer1 = new Manufacturer()
      {
        Name = "Berimo",
        Location = "Berlin",
        Founded = new DateTime(1990, 12, 5),
        NumberOfEmployees = 12000
      };
      Manufacturer manufacturer2 = new Manufacturer()
      {
        Name = "Gokuto",
        Location = "Paris",
        Founded = new DateTime(1888, 11, 21),
        NumberOfEmployees = 5000
      };
      Manufacturer manufacturer3 = new Manufacturer()
      {
        Name = "Lenirko",
        Location = "Madrid",
        Founded = new DateTime(1931, 4, 1),
        NumberOfEmployees = 74532
      };
      Driver driver1 = new Driver()
      {
        Name = "Vasiliy",
        Surname = "Amigo",
        Patronymic = "Olegovich",
        DateOfBirth = new DateTime(1999, 12, 3),
        AddressRegistration = "Kharkiv",
        DriverLicense = "34gsg342vxd"
      };
      Driver driver2 = new Driver()
      {
        Name = "Petro",
        Surname = "Mortol",
        Patronymic = "Artemovych",
        DateOfBirth = new DateTime(1983, 1, 1),
        AddressRegistration = "Kyiv",
        DriverLicense = "25shh653ktc"
      };
      Driver driver3 = new Driver()
      {
        Name = "Andrey",
        Surname = "Vega",
        Patronymic = "Pertovych",
        DateOfBirth = new DateTime(1991, 6, 25),
        AddressRegistration = "Slavyansk",
        DriverLicense = "85nrj478soi"
      };
      Driver driver4 = new Driver()
      {
        Name = "Alexey",
        Surname = "Jokir",
        Patronymic = "Malmedovich",
        DateOfBirth = new DateTime(1953, 8, 16),
        AddressRegistration = "Lviv",
        DriverLicense = "43kgs92xjs"
      };
      Driver driver5 = new Driver()
      {
        Name = "Mikhail",
        Surname = "Man",
        Patronymic = "Pertovych",
        DateOfBirth = new DateTime(1995, 3, 3),
        AddressRegistration = "Mykolaiv",
        DriverLicense = "25fhs69bfl"
      };
      Vehicle vehicle1 = new Vehicle()
      {
        Brand = "BMW",
        Manufacturer = manufacturer1,
        Model = "X67",
        BodyType = "Sedan",
        YearOfIssue = new DateTime(2003, 5, 12),
        VinCode = "gushu429834fhs92"
      };
      Vehicle vehicle2 = new Vehicle()
      {
        Brand = "BMW",
        Manufacturer = manufacturer1,
        Model = "I7",
        BodyType = "Wagon",
        YearOfIssue = new DateTime(2008, 3, 8),
        VinCode = "48tfhdg872dgjg"
      };
      Vehicle vehicle3 = new Vehicle()
      {
        Brand = "AUDI",
        Manufacturer = manufacturer2,
        Model = "TURBO 8",
        BodyType = "Sport coupe",
        YearOfIssue = new DateTime(2019, 10, 1),
        VinCode = "vh87dw8y3dfy2yef"
      };
      Vehicle vehicle4 = new Vehicle()
      {
        Brand = "MERCEDES",
        Manufacturer = manufacturer3,
        Model = "GT-4",
        BodyType = "Coupe",
        YearOfIssue = new DateTime(2015, 8, 13),
        VinCode = "dghsju3y9ysdg8g"
      };
      Registration registration1 = new Registration()
      {
        Vehicle = vehicle1,
        Color = Color.Red,
        ConditionCar = ConditionCar.Excellent,
        Owner = driver1,
        Drivers = new List<Driver>() { driver2, driver4 }
      };
      Registration registration2 = new Registration()
      {
        Vehicle = vehicle1,
        Color = Color.Blue,
        ConditionCar = ConditionCar.Good,
        Owner = driver3,
        Drivers = new List<Driver>() { driver1, driver4 }
      };
      Registration registration3 = new Registration()
      {
        Vehicle = vehicle2,
        Color = Color.Aqua,
        ConditionCar = ConditionCar.Good,
        Owner = driver5,
        Drivers = new List<Driver>()
        {
          driver1,
          driver2,
          driver3
        }
      };
      Registration registration4 = new Registration()
      {
        Vehicle = vehicle3,
        Color = Color.Black,
        ConditionCar = ConditionCar.Bad,
        Owner = driver5,
        Drivers = new List<Driver>()
        {
          driver3,
          driver4,
          driver2
        }
      };
      Registration registration5 = new Registration()
      {
        Vehicle = vehicle4,
        Color = Color.White,
        ConditionCar = ConditionCar.Medium,
        Owner = driver2,
        Drivers = new List<Driver>()
        {
          driver3,
          driver1,
          driver5
        }
      };
      List<Registration> source = new List<Registration>()
      {
        registration1,
        registration2,
        registration3,
        registration4,
        registration5
      };
      Print(registration1.Drivers.Select((x => x)));
      Print(registration5.Drivers.Select((x => x.Name)));
      Print(registration2.Drivers.Intersect(registration3.Drivers));
      Print(source.Select((x => x.Vehicle.Manufacturer)).Where((m => m.NumberOfEmployees > 10000)).Distinct());
      Console.WriteLine("Average number of employee is {0}", source.Select(x => x.Vehicle.Manufacturer.NumberOfEmployees).Average());
        Print(source.GroupBy(registration => registration.Vehicle).Select(g => new
        {
          Vehicle = g.Key,
          Count = g.Count()
        }));
      IEnumerable<Driver> drivers = registration1.Drivers.Union(registration3.Drivers);
      Print(drivers);
      Print(drivers.OrderBy((x => x.DateOfBirth)));
      Print(drivers.Union( registration5.Drivers).Where((x => x.Surname.ToUpper().StartsWith('A'))));
      Console.WriteLine(registration5.Drivers.Select((x => x.Surname)).Aggregate("", ((longest, next) => next.Length <= longest.Length ? longest : next), (surname => surname.ToUpper())));
      Print(registration1.Drivers.Except(registration3.Drivers));
      Print(source.TakeWhile((x => x.ConditionCar > 0)));
      Console.WriteLine(registration1.Drivers.ElementAtOrDefault(224));
      Print(registration1.Drivers.Zip( registration2.Drivers, (first, second) => string.Format("FIRST REGISTRATION: {0}\nSECOND REGISTRATION: {1}\n\n", first, second)));
    }

    private static void Print<T>(IEnumerable<T> list)
    {
      list.ToList<T>().ForEach((Action<T>) (x => Console.WriteLine((object) x)));
      Console.WriteLine("-----------------------------------------------------------------------------------");
    }
    }
}