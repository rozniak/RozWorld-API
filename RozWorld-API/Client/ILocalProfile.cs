/**
 * Oddmatics.RozWorld.API.Client.ILocalProfile -- RozWorld Client Profile
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Client.Input;

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a local player profile.
    /// </summary>
    public interface ILocalProfile
    {
        /// <summary>
        /// Gets the input preferences for this profile.
        /// </summary>
        IInputPreferences InputPreferences { get; }

        /// <summary>
        /// Gets the name of this profile.
        /// </summary>
        string Name { get; }
    }
}
