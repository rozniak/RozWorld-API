/**
 * Oddmatics.RozWorld.API.Generic.Colour -- Colour
 * 
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents a colour.
    /// </summary>
    public struct Colour
    {
        /// <summary>
        /// Gets or sets the alpha (transparency) value of this colour.
        /// </summary>
        public byte Alpha { get; set; }

        /// <summary>
        /// Gets or sets the red value of this colour.
        /// </summary>
        public byte Blue { get; set; }

        /// <summary>
        /// Gets or sets the blue value of this colour.
        /// </summary>
        public byte Green { get; set; }

        /// <summary>
        /// Gets or sets the green value of this colour.
        /// </summary>
        public byte Red { get; set; }


        /// <summary>
        /// Initialises a new instance of the Colour class with specified colour values.
        /// </summary>
        /// <param name="red">The red colour value.</param>
        /// <param name="green">The green colour value.</param>
        /// <param name="blue">The blue colour value.</param>
        /// <param name="alpha">The alpha (transparency) colour value.</param>
        public Colour (byte red, byte green, byte blue, byte alpha)
            : this()
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
    }
}
