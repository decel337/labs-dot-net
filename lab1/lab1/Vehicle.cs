using System;

namespace lab1
{
    public class Vehicle
    {
        public string Brand { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public string Model { get; set; }

        public string BodyType { get; set; }

        public DateTime YearOfIssue { get; set; }

        public string VinCode { get; set; }

        public override string ToString() => string.Format("Car brand is {0} and model is {1}. {2} and year of issue is {3}. Body type, vincode is {4}, {5}", (object) this.Brand, (object) this.Model, (object) this.Manufacturer, (object) this.YearOfIssue.Year, (object) this.BodyType, (object) this.VinCode);
    }
}