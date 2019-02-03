using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_DavidAruldass
{
    
    public class Desk
    {
        public enum Surface
        { // the string should be Surface which is what teacher had 

            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        // creates private variables for the follwing classes
        public decimal Width{ get; set; } // is it string or int 
        public decimal Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public Surface SurfaceMaterial { get; set; }
    }
}
