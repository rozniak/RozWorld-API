﻿/**
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
    public interface Player
    {
        /// <summary>
        /// Gets the username of this player.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the nickname of this player.
        /// </summary>
        string Nickname { get; set; }

        /// <summary>
        /// Gets or sets the angle this player is facing.
        /// </summary>
        double Angle { get; set; }

        /// <summary>
        /// Gets the cardinal direction this player is facing.
        /// </summary>
        CardinalDirection Direction { get; }

        /// <summary>
        /// Gets or sets this player's game mode.
        /// </summary>
        PlayerGameMode GameMode { get; set; }

        /// <summary>
        /// Gets or sets this player's health.
        /// </summary>
        uint Health { get; set; }

        /// <summary>
        /// Gets or sets this player's maximum health.
        /// </summary>
        uint MaxHealth { get; set; }

        /// <summary>
        /// Gets or sets whether this player is dead or not.
        /// </summary>
        bool IsDead { get; }

        /// <summary>
        /// Gets or sets this player's movement speed.
        /// </summary>
        ushort Speed { get; set; }

        /// <summary>
        /// Gets this player's current speed.
        /// </summary>
        ushort CurrentSpeed { get; }

        /// <summary>
        /// Gets the parent server of this player.
        /// </summary>
        Server ParentServer { get; }

        
        /// <summary>
        /// Kicks this player from the server.
        /// </summary>
        /// <param name="reason">The reason the player will see to explain why they got kicked.</param>
        void Kick(string reason = "");

        /// <summary>
        /// Heals this player.
        /// </summary>
        /// <param name="Amount">The amount to heal this player.</param>
        void Heal(uint Amount = uint.MaxValue);

        /// <summary>
        /// Sends a message to this player.
        /// </summary>
        /// <param name="message">The contents of the message to send.</param>
        void SendMessage(string message);

        /// <summary>
        /// Deals some damage to this player.
        /// </summary>
        /// <param name="damage">The amount of damage to deal.</param>
        void DealDamage(uint damage);
    }
}
