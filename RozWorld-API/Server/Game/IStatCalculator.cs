/**
 * Oddmatics.RozWorld.API.Server.Game.StatCalculator -- RozWorld Entity Statistics Calculator
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Game
{
    /// <summary>
    /// Represents a statistics calculator.
    /// </summary>
    public interface IStatCalculator
    {
        /// <summary>
        /// Gets the maximum health at the current level.
        /// </summary>
        /// <param name="level">The value to use for the current level.</param>
        /// <param name="mu">The value to use for the constant &mu;.</param>
        /// <returns>The maximum health at the current level.</returns>
        int GetMaxHealth(int level, double mu = 1);

        /// <summary>
        /// Gets the maxmimum mojo at the current level.
        /// </summary>
        /// <param name="level">The value to use for the current level.</param>
        /// <param name="mu">The value to use for the constant &mu;.</param>
        /// <returns>The maximum mojo at the current level.</returns>
        int GetMaxMojo(int level, double mu = 1);

        /// <summary>
        /// Gets the required experience points to reach the next level.
        /// </summary>
        /// <param name="level">The value to use for the current level.</param>
        /// <param name="mu">The value to use for the constant &mu;.</param>
        /// <returns>The required experience points to reach the next level.</returns>
        int GetRequiredExp(int level, double mu = 1);
    }
}
