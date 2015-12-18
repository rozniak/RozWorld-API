/**
 * RozWorld-API.Event.PlayerGameModeEvent -- RozWorld Player Game Mode Change Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using RozWorld_API.Entity;

namespace RozWorld_API.Event
{
    public delegate void PlayerGameModeEvent(PlayerGameModeEventArgs e);

    public class PlayerGameModeEventArgs
    {
        /// <summary>
        /// Gets the player whose game mode is being changed.
        /// </summary>
        public Player Player { get; private set; }

        /// <summary>
        /// Gets the new game mode the player has changed to.
        /// </summary>
        public PlayerGameMode NewGameMode { get; private set; }

        /// <summary>
        /// Gets the old game mode the player used to be.
        /// </summary>
        public PlayerGameMode OldGameMode { get; private set; }


        public PlayerGameModeEventArgs(Player player, PlayerGameMode newGameMode, PlayerGameMode oldGameMode)
        {
            Player = player;
            NewGameMode = newGameMode;
            OldGameMode = oldGameMode;
        }
    }
}
