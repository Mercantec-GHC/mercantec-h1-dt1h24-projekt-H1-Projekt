using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain_Models
{
    public abstract class baseclass
    {
        public int Brand
        {
            get;
            set;
            
            
        }

        public int Model
        {
            get => default;
            set
            {
            }
        }

        public int Year
        {
            get => default;
            set
            {
            }
        }

        public int Price
        {
            get => default;
            set
            {
            }
        }

        public int Kilometertal
        {
            get => default;
            set
            {
            }
        }

        public int Fueltype
        {
            get => default;
            set
            {
            }
        }

        public int color
        {
            get => default;
            set
            {
            }
        }

        public int Geartype
        {
            get => default;
            set
            {
            }
        }

        public int Description
        {
            get => default;
            set
            {
            }
        }

        public int Horsepower
        {
            get => default;
            set
            {
            }
        }

        public int type
        {
            get => default;
            set
            {
            }
        }

        public int Mileage
        {
            get => default;
            set
            {
            }
        }
    }

    public class Car : baseclass
    {
        public int Doors
        {
            get => default;
            set
            {
            }
        }

        public int Wheeldrive
        {
            get => default;
            set
            {
            }
        }

        public int Esp
        {
            get => default;
            set
            {
            }
        }

        public int AC
        {
            get => default;
            set
            {
            }
        }
    }

    public class motocycle : baseclass
    {

        public int MotorCtm
        {
            get => default;
            set
            {
            }
        }

        public int HasSideCar
        {
            get => default;
            set
            {
            }
        }

        public int BagageBox
        {
            get => default;
            set
            {
            }
        }
    }

    public class EV : Car
    {
        public int KMPerKwH
        {
            get => default;
            set
            {
            }
        }

        public int BatteryCapacity
        {
            get => default;
            set
            {
            }
        }
    }

    public class DieselBenzin : Car
    {
        public int KMPerLiter
        {
            get => default;
            set
            {
            }
        }

        public int Cylinders
        {
            get => default;
            set
            {
            }
        }

        public int Liter
        {
            get => default;
            set
            {
            }
        }
    }

    public class EBike : motocycle
    {
        public int MBattery
        {
            get => default;
            set
            {
            }
        }

        public int MKmPerKwH
        {
            get => default;
            set
            {
            }
        }
    }

    public class Benzin : motocycle
    {
        public int MCylinders
        {
            get => default;
            set
            {
            }
        }
    }

    public class BikeConstructor
    {
    }
}
