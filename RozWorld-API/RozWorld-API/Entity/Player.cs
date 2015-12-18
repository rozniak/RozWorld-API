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

using RozWorld_API.Level;

namespace RozWorld_API.Entity
{
    public interface Player
    {
        /// <summary>
        /// Gets or sets the username of this player.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets or sets the nickname of this player.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the angle this player is facing.
        /// </summary>
        public double Angle { get; protected set; }

        /// <summary>
        /// Gets the cardinal direction this player is facing.
        /// </summary>
        public CardinalDirection Direction { get; }
    }
}
