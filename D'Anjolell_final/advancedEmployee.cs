using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_final
{
    class advancedEmployee : superEmployee
    {
        //Declare Variables
        private string _advancedLevel;
        private int _advancedOffice;

        //Constructor that sets all variables to default values
        public advancedEmployee()
        {

        }

        public string advancedLevel
        {
            //Getter and setter for level variable
            get
            {
                return _advancedLevel;
            }
            set
            {
                _advancedLevel = value;
            }
        }

        public int advancedOffice
        {
            //Getter and setter for office variable
            get
            {
                return _advancedOffice;
            }
            set
            {
                _advancedOffice = value;
            }
        }
    }
}
