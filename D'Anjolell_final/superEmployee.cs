using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_final
{
    class superEmployee : baseEmployee
    {
        //Declare Variables
        private double _superRate;
        private int _superHours;

        //Constructor that sets all variables to default values
        public superEmployee()
        {

        }

        public double superRate
        {
            //Getter and setter for rate variable
            get
            {
                return _superRate;
            }
            set
            {
                _superRate = value;
            }
        }

        public int superHours
        {
            //Getter and setter for hours variable
            get
            {
                return _superHours;
            }
            set
            {
                _superHours = value;
            }
        }
    }
}
