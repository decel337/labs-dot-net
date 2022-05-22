using System.Collections.Generic;
using System.Drawing;

namespace lab1
{
    public class Registration
    {
        public Vehicle Vehicle { get; set; }

        public ConditionCar ConditionCar { get; set; }

        public Color Color { get; set; }

        public Driver Owner { get; set; }

        public List<Driver> Drivers { get; set; }

        public override string ToString() => string.Format("{0}. Condition car is {1} and color is {2}. Owner is {3} and drivers is {4}", (object) this.Vehicle, (object) this.ConditionCar, (object) this.Color, (object) this.Owner, (object) string.Join<Driver>(", ", (IEnumerable<Driver>) this.Drivers));
    }
}