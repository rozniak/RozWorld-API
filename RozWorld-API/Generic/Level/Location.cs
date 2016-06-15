/**
 * Oddmatics.RozWorld.API.Generic.Level.Location -- RozWorld World Location
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Level
{
    /// <summary>
    /// Represents a location inside a world.
    /// </summary>
    public struct Location
    {
        /// <summary>
        /// Gets the x-coordinate of this Location within a segment.
        /// </summary>
        public double LocalX { get; private set; }

        /// <summary>
        /// Gets the y-coordinate of this Location within a segment.
        /// </summary>
        public double LocalY { get; private set; }

        /// <summary>
        /// Gets the x-coordinate of the segment that this Location is inside of.
        /// </summary>
        public int SegmentX { get; private set; }

        /// <summary>
        /// Gets the y-coordinate of the segment that this Location is inside of.
        /// </summary>
        public int SegmentY { get; private set; }

        /// <summary>
        /// Gets the z-coordinate of the segment that this Location is inside of.
        /// </summary>
        public int SegmentZ { get; private set; }

        /// <summary>
        /// Gets the IWorld that this Location is inside of.
        /// </summary>
        public IWorld World { get; private set; }


        /// <summary>
        /// Initializes a new instance of the Location class with the specified local and segment coordinates.
        /// </summary>
        /// <param name="localX">The local x-coordinate.</param>
        /// <param name="localY">The local y-coordinate.</param>
        /// <param name="segX">The segment's x-coordinate.</param>
        /// <param name="segY">The segment's y-coordinate.</param>
        /// <param name="segZ">The segment's z-coordinate.</param>
        public Location(double localX, double localY, int segX, int segY, int segZ) : this()
        {
            LocalX = localX;
            LocalY = localY;
            SegmentX = segX;
            SegmentY = segY;
            SegmentZ = segZ;
            World = null;
        }

        /// <summary>
        /// Initialises a new instance of the Location class with the specified local and segment coordinates in a given IWorld.
        /// </summary>
        /// <param name="localX">The local x-coordinate.</param>
        /// <param name="localY">The local y-coordinate.</param>
        /// <param name="segX">The segment's x-coordinate.</param>
        /// <param name="segY">The segment's y-coordinate.</param>
        /// <param name="segZ">The segment's z-coordinate.</param>
        /// <param name="world">The IWorld these coordinates are inside of.</param>
        public Location(double localX, double localY, int segX, int segY, int segZ, IWorld world) : this()
        {
            LocalX = localX;
            LocalY = localY;
            SegmentX = segX;
            SegmentY = segY;
            SegmentZ = segZ;
            World = world;
        }
    }
}
