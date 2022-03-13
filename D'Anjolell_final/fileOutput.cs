using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_final
{
    class fileOutput
    {
        //Declare Variable
        private string[] _arrayOutput;
        StreamWriter _outputFile;

        //Constructor that sets all variables to default values
        public fileOutput()
        {

        }

        public string[] arrayOutput
        {
            //Getter and setter for name variable
            get
            {
                return _arrayOutput;
            }
            set
            {
                _arrayOutput = value;
            }
        }
        public StreamWriter outputFile
        {
            //Getter and setter for name variable
            get
            {
                return _outputFile;
            }
            set
            {
                _outputFile = value;
            }
        }
    }
}
