/**
 * Oddmatics.RozWorld.API.Generic.Event.TrustedPluginCheckCallback -- RozWorld Trusted Plugin Check Callback
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic.Event
{
    /// <summary>
    /// Represents the method that will be called when asking the administrator to confirm that they trust a plugin before loading it.
    /// </summary>
    /// <param name="file">The filepath of the plugin.</param>
    /// <returns>True if the administrator has confirmed that they trust the plugin file.</returns>
    public delegate bool TrustedPluginCheckCallback(string file);
}
