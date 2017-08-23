/**
 * Oddmatics.RozWorld.API.Generic.RwGame -- RozWorld Game Instancce
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic.Event;

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents the active game instance.
    /// </summary>
    public interface IRwGame
    {
        /// <summary>
        /// Occurs when the logic update portion of the main game loop is reached.
        /// </summary>
        event GameUpdateEventHandler Updated;
    }
}
