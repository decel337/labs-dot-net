using System;
using System.Drawing;
using System.Xml.Linq;

namespace lab2
{
    public class FileOperation
    {
        public static void CreateXML(string nameFile)
        {
            XDocument xdoc = new XDocument(new XElement("Registrations",
                            // registration1
                            new XElement("Registration",
                                new XAttribute("name", "registration1"),
                                
                                new XElement("Vehicle",
                                    new XAttribute("name", "vehicle1"),
                                    new XElement("Brand", "BMW"),
                                    new XElement("Manufacturer", 
                                        new XAttribute("name", "manufacturer1"),
                                        new XElement("Name", "Berimo"),
                                        new XElement("Location", "Berlin"),
                                        new XElement("Founded", new DateTime(1990, 12, 5)),
                                        new XElement("NumberOfEmployee", 12000)), 
                                    new XElement("Model", "X67"),
                                    new XElement("BodyType", "Sedan"),
                                    new XElement("YearOfIssue", new DateTime(2003, 5, 12)),
                                    new XElement("VinCode", "gushu429834fhs92")),
                                
                                new XElement("Color", Color.Red),
                                
                                new XElement("ConditionCar", ConditionCar.Excellent),
                                
                                new XElement("Owner", new XElement("Driver",
                                    new XAttribute("name", "driver1"),
                                    new XElement("Name", "Vasiliy"),
                                    new XElement("Surname", "Amigo"),
                                    new XElement("Patronymic", "Olegovich"),
                                    new XElement("DateOfBirth", new DateTime(1999, 12, 3)),
                                    new XElement("AddressRegistration", "Kharkiv"),
                                    new XElement("DriverLicense", "34gsg342vxd"))),
                                
                                new XElement("Drivers", 
                                    new XElement("Driver",
                                        new XAttribute("name", "driver2"),
                                        new XElement("Name", "Petro"),
                                        new XElement("Surname", "Mortol"),
                                        new XElement("Patronymic", "Artemovych"),
                                        new XElement("DateOfBirth", new DateTime(1983, 1, 1)),
                                        new XElement("AddressRegistration", "Kyiv"),
                                        new XElement("DriverLicense", "25shh653ktc")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver4"),
                                        new XElement("Name", "Alexey"),
                                        new XElement("Surname", "Jokir"),
                                        new XElement("Patronymic", "Malmedovich"),
                                        new XElement("DateOfBirth", new DateTime(1953, 8, 16)),
                                        new XElement("AddressRegistration", "Lviv"),
                                        new XElement("DriverLicense", "43kgs92xjs")))),
                            
                            // registration2
                            new XElement("Registration",
                                new XAttribute("name", "registration2"),
                                
                                new XElement("Vehicle",
                                    new XAttribute("name", "vehicle1"),
                                    new XElement("Brand", "BMW"),
                                    new XElement("Manufacturer", 
                                        new XAttribute("name", "manufacturer1"),
                                        new XElement("Name", "Berimo"),
                                        new XElement("Location", "Berlin"),
                                        new XElement("Founded", new DateTime(1990, 12, 5)),
                                        new XElement("NumberOfEmployee", 12000)), 
                                    new XElement("Model", "X67"),
                                    new XElement("BodyType", "Sedan"),
                                    new XElement("YearOfIssue", new DateTime(2003, 5, 12)),
                                    new XElement("VinCode", "gushu429834fhs92")),
                                
                                new XElement("Color", Color.Blue),
                                
                                new XElement("ConditionCar", ConditionCar.Good),
                                
                                new XElement("Owner", new XElement("Driver",
                                    new XAttribute("name", "driver3"),
                                    new XElement("Name", "Andrey"),
                                    new XElement("Surname", "Vega"),
                                    new XElement("Patronymic", "Pertovych"),
                                    new XElement("DateOfBirth", new DateTime(1991, 6, 25),
                                    new XElement("AddressRegistration", "Slavyansk"),
                                    new XElement("DriverLicense", "85nrj478soi"))),
                                
                                new XElement("Drivers", 
                                    new XElement("Driver",
                                        new XAttribute("name", "driver1"),
                                        new XElement("Name", "Vasiliy"),
                                        new XElement("Surname", "Amigo"),
                                        new XElement("Patronymic", "Olegovich"),
                                        new XElement("DateOfBirth", new DateTime(1999, 12, 3)),
                                        new XElement("AddressRegistration", "Kharkiv"),
                                        new XElement("DriverLicense", "34gsg342vxd")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver4"),
                                        new XElement("Name", "Alexey"),
                                        new XElement("Surname", "Jokir"),
                                        new XElement("Patronymic", "Malmedovich"),
                                        new XElement("DateOfBirth", new DateTime(1953, 8, 16)),
                                        new XElement("AddressRegistration", "Lviv"),
                                        new XElement("DriverLicense", "43kgs92xjs"))))),
                            
                            // registration3
                            new XElement("Registration",
                                new XAttribute("name", "registration3"),
                                
                                new XElement("Vehicle",
                                    new XAttribute("name", "vehicle2"),
                                    new XElement("Brand", "BMW"),
                                    new XElement("Manufacturer", 
                                        new XAttribute("name", "manufacturer1"),
                                        new XElement("Name", "Berimo"),
                                        new XElement("Location", "Berlin"),
                                        new XElement("Founded", new DateTime(1990, 12, 5)),
                                        new XElement("NumberOfEmployee", 12000)), 
                                    new XElement("Model", "I7"),
                                    new XElement("BodyType", "Wagon"),
                                    new XElement("YearOfIssue", new DateTime(2008, 3, 8)),
                                    new XElement("VinCode", "48tfhdg872dgjg")),
                                
                                new XElement("Color", Color.Aqua),
                                
                                new XElement("ConditionCar", ConditionCar.Good),
                                
                                new XElement("Owner", new XElement("Driver",
                                    new XAttribute("name", "driver5"),
                                    new XElement("Name", "Mikhail"),
                                    new XElement("Surname", "Man"),
                                    new XElement("Patronymic", "Pertovych"),
                                    new XElement("DateOfBirth", new DateTime(1995, 3, 3)),
                                    new XElement("AddressRegistration", "Mykolaiv"),
                                    new XElement("DriverLicense", "25fhs69bfl"))),
                                
                                new XElement("Drivers", 
                                    new XElement("Driver",
                                        new XAttribute("name", "driver1"),
                                        new XElement("Name", "Vasiliy"),
                                        new XElement("Surname", "Amigo"),
                                        new XElement("Patronymic", "Olegovich"),
                                        new XElement("DateOfBirth", new DateTime(1999, 12, 3)),
                                        new XElement("AddressRegistration", "Kharkiv"),
                                        new XElement("DriverLicense", "34gsg342vxd")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver2"),
                                        new XElement("Name", "Petro"),
                                        new XElement("Surname", "Mortol"),
                                        new XElement("Patronymic", "Artemovych"),
                                        new XElement("DateOfBirth", new DateTime(1983, 1, 1)),
                                        new XElement("AddressRegistration", "Kyiv"),
                                        new XElement("DriverLicense", "25shh653ktc")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver3"),
                                        new XElement("Name", "Andrey"),
                                        new XElement("Surname", "Vega"),
                                        new XElement("Patronymic", "Pertovych"),
                                        new XElement("DateOfBirth", new DateTime(1991, 6, 25)), 
                                        new XElement("AddressRegistration", "Slavyansk"),
                                        new XElement("DriverLicense", "85nrj478soi")))),
                            
                            // registration4
                            new XElement("Registration",
                                new XAttribute("name", "registration4"),
                                
                                new XElement("Vehicle",
                                    new XAttribute("name", "vehicle3"),
                                    new XElement("Brand", "AUDI"),
                                    new XElement("Manufacturer", 
                                        new XAttribute("name", "manufacturer2"),
                                        new XElement("Name", "Gokuto"),
                                        new XElement("Location", "Paris"),
                                        new XElement("Founded", new DateTime(1888, 11, 21)),
                                        new XElement("NumberOfEmployee", 5000)), 
                                    new XElement("Model", "TURBO 8"),
                                    new XElement("BodyType", "Sport coupe"),
                                    new XElement("YearOfIssue", new DateTime(2019, 10, 1)),
                                    new XElement("VinCode", "vh87dw8y3dfy2yef")),
                                
                                new XElement("Color", Color.Black),
                                
                                new XElement("ConditionCar", ConditionCar.Bad),
                                
                                new XElement("Owner", new XElement("Driver",
                                    new XAttribute("name", "driver5"),
                                    new XElement("Name", "Mikhail"),
                                    new XElement("Surname", "Man"),
                                    new XElement("Patronymic", "Pertovych"),
                                    new XElement("DateOfBirth", new DateTime(1995, 3, 3)),
                                    new XElement("AddressRegistration", "Mykolaiv"),
                                    new XElement("DriverLicense", "25fhs69bfl"))),
                                
                                new XElement("Drivers", 
                                    new XElement("Driver",
                                        new XAttribute("name", "driver2"),
                                        new XElement("Name", "Petro"),
                                        new XElement("Surname", "Mortol"),
                                        new XElement("Patronymic", "Artemovych"),
                                        new XElement("DateOfBirth", new DateTime(1983, 1, 1)),
                                        new XElement("AddressRegistration", "Kyiv"),
                                        new XElement("DriverLicense", "25shh653ktc")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver4"),
                                        new XElement("Name", "Alexey"),
                                        new XElement("Surname", "Jokir"),
                                        new XElement("Patronymic", "Malmedovich"),
                                        new XElement("DateOfBirth", new DateTime(1953, 8, 16)),
                                        new XElement("AddressRegistration", "Lviv"),
                                        new XElement("DriverLicense", "43kgs92xjs")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver3"),
                                        new XElement("Name", "Andrey"),
                                        new XElement("Surname", "Vega"),
                                        new XElement("Patronymic", "Pertovych"),
                                        new XElement("DateOfBirth", new DateTime(1991, 6, 25)), 
                                        new XElement("AddressRegistration", "Slavyansk"),
                                        new XElement("DriverLicense", "85nrj478soi")))),
                            
                            // registration5
                            new XElement("Registration",
                                new XAttribute("name", "registration5"),
                                
                                new XElement("Vehicle",
                                    new XAttribute("name", "vehicle4"),
                                    new XElement("Brand", "MERCEDES"),
                                    new XElement("Manufacturer", 
                                        new XAttribute("name", "manufacturer3"),
                                        new XElement("Name", "Lenirko"),
                                        new XElement("Location", "Madrid"),
                                        new XElement("Founded", new DateTime(1931, 4, 1)),
                                        new XElement("NumberOfEmployee", 74532)), 
                                    new XElement("Model", "GT-4"),
                                    new XElement("BodyType", "Coupe"),
                                    new XElement("YearOfIssue", new DateTime(2015, 8, 13)),
                                    new XElement("VinCode", "dghsju3y9ysdg8g")),
                                
                                new XElement("Color", Color.White),
                                
                                new XElement("ConditionCar", ConditionCar.Medium),
                                
                                new XElement("Owner", new XElement("Driver",
                                    new XAttribute("name", "driver2"),
                                    new XElement("Name", "Petro"),
                                    new XElement("Surname", "Mortol"),
                                    new XElement("Patronymic", "Artemovych"),
                                    new XElement("DateOfBirth", new DateTime(1983, 1, 1)),
                                    new XElement("AddressRegistration", "Kyiv"),
                                    new XElement("DriverLicense", "25shh653ktc"))),
                                
                                new XElement("Drivers", 
                                    new XElement("Driver",
                                        new XAttribute("name", "driver3"),
                                        new XElement("Name", "Andrey"),
                                        new XElement("Surname", "Vega"),
                                        new XElement("Patronymic", "Pertovych"),
                                        new XElement("DateOfBirth", new DateTime(1991, 6, 25)), 
                                        new XElement("AddressRegistration", "Slavyansk"),
                                        new XElement("DriverLicense", "85nrj478soi")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver5"),
                                        new XElement("Name", "Mikhail"),
                                        new XElement("Surname", "Man"),
                                        new XElement("Patronymic", "Pertovych"),
                                        new XElement("DateOfBirth", new DateTime(1995, 3, 3)),
                                        new XElement("AddressRegistration", "Mykolaiv"),
                                        new XElement("DriverLicense", "25fhs69bfl")),
                                    new XElement("Driver",
                                        new XAttribute("name", "driver1"),
                                        new XElement("Name", "Vasiliy"),
                                        new XElement("Surname", "Amigo"),
                                        new XElement("Patronymic", "Olegovich"),
                                        new XElement("DateOfBirth", new DateTime(1999, 12, 3)),
                                        new XElement("AddressRegistration", "Kharkiv"),
                                        new XElement("DriverLicense", "34gsg342vxd"))))));
                        xdoc.Save(nameFile);
        }

        public static void ReadXML(string nameFile)
        {
            
        }
    }
}