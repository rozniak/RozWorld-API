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
using Oddmatics.RozWorld.API.Server.Entities;

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


        /// <summary>
        /// Gets an IEntity instance in this IWorld by its ID.
        /// </summary>
        /// <param name="id">The ID of the IEntity.</param>
        /// <returns>The IEntity instance associated with the specified ID.</returns>
        Entity GetEntityById(ushort id);

        /// <summary>
        /// Places an IEntity inside of this IWorld.
        /// </summary>
        /// <param name="entity">The IEntity to spawn.</param>
        /// <param name="segX">The x-coordinate of the target segment.</param>
        /// <param name="segY">The y-coordinate of the target segment.</param>
        /// <param name="segZ">The z-coordinate of the target segment.</param>
        /// <param name="localX">The target local x-coordinate of the segment.</param>
        /// <param name="localY">The target local y-coordinate of the segment.</param>
        void PutEntity(Entity entity, int segX, int segY, int segZ, int localX, int localY);

        /// <summary>
        /// Places an IEntity inside of this IWorld.
        /// </summary>
        /// <param name="entity">The IEntity to spawn.</param>
        /// <param name="location">The target Location to spawn at.</param>
        void PutEntity(Entity entity, Location location);

        /// <summary>
        /// Changes the animation state of an IEntity to the specified new state.
        /// This function should be used by the IEntity instances themselves, changing an IEntity's state should be
        /// done via the IEntity.ChangeState() method instead.
        /// </summary>
        /// <param name="id">The ID of the IEntity.</param>
        /// <param name="newState">The new state to change to.</param>
        void SetEntityState(ushort id, string newState);

        /// <summary>
        /// Sets the Velocity of an IEntity.
        /// This function should be used by the IEntity instances themselves, changing an IEntity's Velocity should
        /// be done via the IEntity.SetVelocity() method instead.
        /// </summary>
        /// <param name="id">The ID of the IEntity.</param>
        /// <param name="newState"></param>
        void SetEntityVelocity(ushort id, string newState);

        /// <summary>
        /// Teleports an IEntity of the given ID to the specified Location.
        /// This function should be used by the IEntity instances themselves, teleporting an IEntity should be done
        /// via the IEntity.TeleportTo() method instead.
        /// </summary>
        /// <param name="id">The ID of the IEntity.</param>
        /// <param name="destination">The Location to teleport the IEntity to.</param>
        void TeleportEntity(ushort id, Location destination);
    }
}
