using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traininig.Models
{
    //A class that models a car.
    public class Car
    {
        #region Constructors 

        public Car(int Windows, int Doors, string Name)
        {
            this.Windows = Windows;
            this.Doors   = Doors;
            this.Name    = Name;
        }
        #endregion

        #region Properties

        //Indicates the quantity of windows that has the car.
        public int Windows { get; set; }

        //Indicates the quantity of windows that has the car.
        public int Doors { get; set; }
        //Indicates the Name of the Car.
        public string Name {get;set;}



        private string mName

        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        
        #endregion


    }
}
