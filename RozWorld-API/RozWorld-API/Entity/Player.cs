/**
 * RozWorld-API.Entity.Player -- RozWorld Player
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Event;
using RozWorld_API.Level;

namespace RozWorld_API.Entity
{
    public abstract class Player
    {
        /// <summary>
        /// Gets or sets the username of this player.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { if (_Name != null) _Name = value; }
        }
        private string _Name;

        /// <summary>
        /// Gets or sets the nickname of this player.
        /// </summary>
        public virtual string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the angle this player is facing.
        /// </summary>
        public virtual double Angle { get; protected set; }

        /// <summary>
        /// Gets the cardinal direction this player is facing.
        /// </summary>
        public abstract CardinalDirection Direction { get; }

        /// <summary>
        /// Gets or sets this player's game mode.
        /// </summary>
        public virtual PlayerGameMode GameMode { get; set; }

        /// <summary>
        /// Gets or sets this player's health.
        /// </summary>
        public abstract uint Health;

        /// <summary>
        /// Gets or sets this player's maximum health.
        /// </summary>
        public abstract uint MaxHealth;

        /// <summary>
        /// Gets or sets whether this player is dead or not.
        /// </summary>
        public abstract bool IsDead { get; protected set; }

        /// <summary>
        /// Gets or sets this player's speed.
        /// </summary>
        public ushort Speed;

        /// <summary>
        /// Gets or sets the parent server of this player.
        /// </summary>
        protected Server ParentServer
        {
            get { return _ParentServer; }
            set { if (_ParentServer == null) _ParentServer = value; }
        }
        private Server _ParentServer;
    }
}
