using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it at the beginning.
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }   

        // roll (set a new random face up value)
        /// <summary>
        /// Rolls the die and set the <see cref="FaceValue"/>
        /// to the new number. Returns the new random number,
        /// </summary>
        /// 
        public byte Roll()
        {
            //generate random number
            Random random = new();
            byte newValue = (byte)random.Next(1, 7);
            // set to face value
            FaceValue = newValue;
            // Return new number
            return FaceValue;
        }
    }

}
