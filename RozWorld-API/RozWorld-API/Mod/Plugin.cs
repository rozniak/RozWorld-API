/**
 * RozWorld-API.Mod.Plugin -- RozWorld Server Plugin
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Mod
{
    public interface Plugin
    {
        /// <summary>
        /// Gets the name of this plugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the version of this plugin.
        /// </summary>
        ushort Version { get; }
    }
}
