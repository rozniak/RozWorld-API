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
        public int ChunkX;
        public int ChunkY;
        public int ChunkZ;
        public double LocalX;
        public double LocalY;
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
