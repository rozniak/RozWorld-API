/**
 * RozWorld-API.Level.WorldPosition -- RozWorld World Position Reference
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Level
{
    public struct WorldPosition
    {
        /// <summary>
        /// Gets or sets the x-coordinate representing the chunk this position is inside of.
        /// </summary>
        public int ChunkX;

        /// <summary>
        /// Gets or sets the y-coordinate representing the chunk this position is inside of.
        /// </summary>
        public int ChunkY;

        /// <summary>
        /// Gets or sets the z-coordinate representing the chunk this position is inside of.
        /// </summary>
        public int ChunkZ;

        /// <summary>
        /// Gets or sets the x-coordinate inside of the chunk this position is at.
        /// </summary>
        public double LocalX;

        /// <summary>
        /// Gets or sets the y-coordinate inside of the chunk this position is at.
        /// </summary>
        public double LocalY;

        /// <summary>
        /// Gets or sets the z-coordinate inside of the chunk this position is at.
        /// </summary>
        public double LocalZ;

        
        public WorldPosition(int chunkX, int chunkY, int chunkZ,
            double localX, double localY, double localZ)
        {
            ChunkX = chunkX;
            ChunkY = chunkY;
            ChunkZ = chunkZ;
            LocalX = localX;
            LocalY = localY;
            LocalZ = localZ;
        }
    }
}
