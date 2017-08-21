/**
 * Oddmatics.RozWorld.API.Generic.Game.GameMode -- RozWorld Game Mode
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Game
{
    /// <summary>
    /// Specifies constants defining the game mode that RozWorld will play as.
    /// </summary>
    public enum GameMode
    {
        /// <summary>
        /// Represents the adventure mode, no story/major quest will be generated.
        /// </summary>
        Adventure,
        /// <summary>
        /// Represents the books mode, stories/major quests will be generated.
        /// </summary>
        Books
    }
}
