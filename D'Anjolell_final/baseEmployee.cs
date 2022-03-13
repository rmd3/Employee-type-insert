using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_final
{
    class baseEmployee
    {
        //Declare Variables
        private string _baseName;
        private string _baseEmail;
        private string _baseAddress;

        //Constructor that sets all variables to default values
        public baseEmployee()
        {

        }

        public string baseName
        {
            //Getter and setter for name variable
            get
            {
                return _baseName;
            }
            set
            {
                _baseName = value;
            }
        }

        public string baseEmail
        {
            //Getter and setter for email variable
            get
            {
                return _baseEmail;
            }
            set
            {
                _baseEmail = value;
            }
        }

        public string baseAddress
        {
            //Getter and setter for address variable
            get
            {
                return _baseAddress;
            }
            set
            {
                _baseAddress = value;
            }
        }
    }
}
