/**
 * Oddmatics.RozWorld.API.Server.Game.SafeStatHandler -- RozWorld Safe Statistics Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Server.Game
{
    /// <summary>
    /// Represents a safe statistics handler to keep all statistics in sync.
    /// </summary>
    public class SafeStatHandler
    {
        /// <summary>
        /// Gets the experience points within this SafeStatHandler.
        /// </summary>
        public int Experience { get; private set; }

        /// <summary>
        /// Gets or sets the level within this SafeStatHandler.
        /// </summary>
        public int Level
        {
            get { return _Level; }
            set
            {
                if (value > 0)
                {
                    _Level = value;
                    Experience = 0;
                    MaxHealth = StatCalculator.GetMaxHealth(value);
                    MaxMojo = StatCalculator.GetMaxMojo(value);
                    RequiredExperience = StatCalculator.GetRequiredExp(value);
                }
            }
        }
        /// <summary>
        /// Backing variable for Level.
        /// </summary>
        private int _Level;

        /// <summary>
        /// Gets the maximum health within this SafeStatHandler.
        /// </summary>
        public int MaxHealth { get; private set; }

        /// <summary>
        /// Gets the maximum mojo within this SafeStatHandler.
        /// </summary>
        public int MaxMojo { get; private set; }

        /// <summary>
        /// Gets the required experience points within this SafeStatHandler.
        /// </summary>
        public int RequiredExperience { get; private set; }


        /// <summary>
        /// Gets or sets the IStatCalculator for this SafeStatHandler.
        /// </summary>
        private IStatCalculator StatCalculator;


        /// <summary>
        /// Initialises a new instance of the Velocity class with a specified speed and angle.
        /// </summary>
        /// <param name="statCalc">The IStatCalculator to use.</param>
        public SafeStatHandler(IStatCalculator statCalc)
        {
            if (statCalc == null)
                throw new ArgumentNullException("statCalc parameter cannot be null.");

            StatCalculator = statCalc;
            Level = 1;
        }
    }
}
