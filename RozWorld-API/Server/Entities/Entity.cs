/**
 * Oddmatics.RozWorld.API.Server.Entities.Entity -- RozWorld Entity
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;
using Oddmatics.RozWorld.API.Generic.Level;
using Oddmatics.RozWorld.API.Server.Event;
using System;

namespace Oddmatics.RozWorld.API.Server.Entities
{
    /// <summary>
    /// Represents an entity that exists in a world.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets the age of this Entity.
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Gets the animation state of this Entity.
        /// </summary>
        public byte AnimationState { get; private set; }

        /// <summary>
        /// Gets the ID of this Entity.
        /// </summary>
        public ushort ID { get { return _ID; } set { if (_ID == 0) _ID = value; } }
        private ushort _ID;
        
        /// <summary>
        /// Gets whether this Entity can be controlled externally (eg. by IPlugins).
        /// </summary>
        public abstract bool IsControllable { get; }

        /// <summary>
        /// Gets whether this Entity is flammable.
        /// </summary>
        public abstract bool IsFlammable { get; }

        /// <summary>
        /// Gets or sets whether this Entity is on fire.
        /// </summary>
        public bool IsOnFire
        {
            get { return _IsOnFire; }
            set { _IsOnFire = IsFlammable && value; }
        }
        private bool _IsOnFire;

        /// <summary>
        /// Gets whether this Entity is valid (spawned in an IWorld).
        /// </summary>
        public bool IsValid { get { return false; } } // TODO: code this - should ask server if this entity exists!

        /// <summary>
        /// Gets the location of this Entity.
        /// </summary>
        public Location Location { get; private set; } // Handled by the velocity on Update()

        /// <summary>
        /// Gets or sets the current velocity of this Entity.
        /// </summary>
        public Vector Velocity { get; set; }


        /// <summary>
        /// Occurs when this Entity's animation state changes.
        /// </summary>
        event StateChangedEventHandler StateChanged;


        /// <summary>
        /// Applies a force onto this Entity.
        /// </summary>
        /// <param name="force">The force Vector to apply.</param>
        public void ApplyForce(Vector force)
        {
            // TODO: Some physics calcs for getting resultant velocity vector
        }

        /// <summary>
        /// Changes the animation state of this Entity on clients.
        /// </summary>
        /// <param name="newState">The new animation state.</param>
        /// <param name="loop">Whether the animation should loop.</param>
        /// <param name="nextState">The next animation state after this finishes (if it's not looping).</param>
        protected void ChangeState(byte newState, bool loop, byte nextState = 0)
        {
            if (!RwCore.Server.ContentManager.CheckEntityState(newState, this.GetType()))
                throw new ArgumentException("The specified new state does not exist for this Entity.");

            if (StateChanged != null)
                StateChanged(this, newState, loop, nextState); // Server is a subscriber to this
        }

        /// <summary>
        /// Interacts with this Entity.
        /// </summary>
        /// <param name="sender">The Player interacting.</param>
        public virtual void Interact(Player sender) { }

        /// <summary>
        /// Teleports this Entity to a specified target IEntity.
        /// </summary>
        /// <param name="target">The target IEntity to teleport to.</param>
        public void TeleportTo(Entity target)
        {
            TeleportTo(target.Location);
        }

        /// <summary>
        /// Teleports this Entity to the specified Location.
        /// </summary>
        /// <param name="target">The target Location to teleport to.</param>
        public void TeleportTo(Location target)
        {
            // Do teleport code here for changing the Location and updating the server's info
        }

        /// <summary>
        /// Teleport this IEntity to the specified coordinates.
        /// </summary>
        /// <param name="segX">The x-coordinate of the target segment.</param>
        /// <param name="segY">The y-coordinate of the target segment.</param>
        /// <param name="segZ">The z-coordinate of the target segment.</param>
        /// <param name="localX">The target local x-coordinate of the segment.</param>
        /// <param name="localY">The target local y-coordinate of the segment.</param>
        public void TeleportTo(int localX, int localY, int segX, int segY, int segZ)
        {
            TeleportTo(new Location(localX, localY, segX, segY, segZ, Location.World));
        }


        /// <summary>
        /// [DIRECT INHERITORS ONLY -- ATTACH THIS TO IRWSERVER.TICK EVENT IN YOUR CONSTRUCTOR OR INCLUDE IN UPDATE METHOD]
        /// Performs physics calculations for updating this Entity.
        /// </summary>
        protected void EntityUpdate()
        {
            // TODO: Some physics calcs for getting the new Location of this Entity based on velocity
        }
    }
}
