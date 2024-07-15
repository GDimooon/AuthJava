using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingComplex
{
    class Housing
    {
        public int ComplexNumber { get; set; } // номер комплекса
        public int NumberOfResidents { get; set; } // количество жителей
        public int AirSupply { get; set; } // количество запасов воздуха 

        // константа расхода воздуха на 1 человека в сутки
        private const int AIR_CONSUMPTION = 10;

        public Housing(int complexNumber, int numberOfResidents, int airSupply)
        {
            ComplexNumber = complexNumber;
            NumberOfResidents = numberOfResidents;
            AirSupply = airSupply;
        }

        public int GetAirSupplyDays()
        {
            int days = AirSupply / (NumberOfResidents * AIR_CONSUMPTION);
            return days;
        }
    }
}   
