using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traininig.Models
{
    //A class that models a computer.
    public class Computer
    {
        #region Constructors

        public Computer(int Ram, string SO)
        {
            this.Ram = Ram;
            this.SO = SO;
        }

        #endregion

        #region Properties

        //Indicates the quantity of ram that has the computer.
        public int Ram { get; set; }
        public string SO { get; set; }




        //Indicates the operation system of the computer.

        private string mSO
        {
            get
            {
                return this.SO;
            }
            set
            {
                this.SO = value ;
            }
        }

        #endregion


    }
}
