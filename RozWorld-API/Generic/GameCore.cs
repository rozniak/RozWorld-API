

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents the unified RozWorld game-core.
    /// </summary>
    public sealed class GameCore
    {
        /// <summary>
        /// Verifies that the loaded core game portions are in sync.
        /// </summary>
        /// <returns>True if tests on loaded core portons are in sync and valid.</returns>
        public bool VerifyGame()
        {
            if (RwCore.Server != null && RwCore.Client != null) // If both are loaded, then make sure the version matches
                return RwCore.Server.RozWorldVersion == RwCore.Client.RozWorldVersion;
            else if (RwCore.Server == null && RwCore.Client == null) // If neither are loaded, then this fails
                return false;

            return true; // If only one is loaded, then no version checks need to be done
        }
    }
}
