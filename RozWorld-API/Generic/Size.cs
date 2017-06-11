/**
 * Oddmatics.RozWorld.API.Generic.Size -- 2D Size
 * 
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents a size in 2D.
    /// </summary>
    public struct Size
    {
        /// <summary>
        /// Gets or sets the height of this size.
        /// </summary>
        public int Height;

        /// <summary>
        /// Gets or sets the width of this size.
        /// </summary>
        public int Width;


        /// <summary>
        /// Initialises a new instance of the Size class with a specified width and height.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public Size(int height, int width)
            : this()
        {
            Height = height;
            Width = width;
        }
    }
}
