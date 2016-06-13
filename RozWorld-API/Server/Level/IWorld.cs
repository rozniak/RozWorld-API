/**
 * Oddmatics.RozWorld.API.Server.Level.IWorld -- RozWorld Server-side World
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Level;

namespace Oddmatics.RozWorld.API.Server.Level
{
    /// <summary>
    /// Represents a server-side world.
    /// </summary>
    public interface IWorld : RozWorld.API.Generic.Level.IWorld
    {
        /// <summary>
        /// Gets the directory path this IWorld is stored in.
        /// </summary>
        string DirectoryPath { get; }

        /// <summary>
        /// Gets the generator used for 
        /// </summary>
        IWorldGenerator Generator { get; }

        /// <summary>
        /// Gets the name of this IWorld.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the spawn point for this IWorld.
        /// </summary>
        Location SpawnPoint { get; set; }
    }
}
