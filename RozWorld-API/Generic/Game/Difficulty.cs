/**
 * Oddmatics.RozWorld.API.Generic.Game.Difficulty -- RozWorld Game Difficulty
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Game
{
    /// <summary>
    /// Specifies constants defining the game difficulty.
    /// </summary>
    public enum Difficulty
    {
        /// <summary>
        /// Represents the easiest difficulty.
        /// </summary>
        VeryEasy = 1,
        /// <summary>
        /// Represents the second easiest difficulty.
        /// </summary>
        Easy = 2,
        /// <summary>
        /// Represents intermediate difficulty.
        /// </summary>
        Medium = 3,
        /// <summary>
        /// Represents the second most difficult difficulty.
        /// </summary>
        Difficult = 4,
        /// <summary>
        /// Represents the most difficult difficulty.
        /// </summary>
        VeryDifficult = 5
    }
}
