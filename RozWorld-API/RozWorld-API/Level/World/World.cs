/**
 * RozWorld-API.Level.World.World -- RozWorld World
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Thing;

namespace RozWorld_API.Level.World
{
    public interface World
    {
        /// <summary>
        /// Gets the name of this world.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the generator assigned to this world.
        /// </summary>
        WorldGenerator Generator { get; }


        /// <summary>
        /// Gets a chunk by its position in this world.
        /// </summary>
        /// <param name="x">The x-coordinate of the chunk.</param>
        /// <param name="y">The y-coordinate of the chunk.</param>
        /// <param name="z">The z-coordinate of the chunk.</param>
        /// <returns>The chunk at the specified location.</returns>
        Chunk GetChunkAt(int x, int y, int z);


        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="position">The position to explode at.</param>
        void MakeExplosion(WorldPosition position);
        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="position">The position to explode at.</param>
        /// <param name="intensity">The damage distribution cutoff of the explosion. (Values in range of 0.0 - 1.0)</param>
        void MakeExplosion(WorldPosition position, double intensity);
        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="position">The position to explode at.</param>
        /// <param name="blastRadius">The blast radius of the explosion.</param>
        void MakeExplosion(WorldPosition position, ushort blastRadius);
        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="position">The position to explode at.</param>
        /// <param name="intensity">The damage distribution cutoff of the explosion. (Values in range of 0.0 - 1.0)</param>
        /// <param name="blastRadius">The blast radius of the explosion.</param>
        void MakeExplosion(WorldPosition position, double intensity, ushort blastRadius);
        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="explosion">The explosion to make in this world.</param>
        void MakeExplosion(Explosion explosion);
        /// <summary>
        /// Makes an explosion at a given position in this world.
        /// </summary>
        /// <param name="position">The position to explode at.</param>
        /// <param name="explosion">The explosion to make in this world.</param>
        void MakeExplosion(WorldPosition position, Explosion explosion);
    }
}
