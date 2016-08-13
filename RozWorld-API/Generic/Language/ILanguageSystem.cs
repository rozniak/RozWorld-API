/**
 * Oddmatics.RozWorld.API.Generic.Language.ILanguageSystem -- RozWorld Language System
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Generic.Language
{
    /// <summary>
    /// Represents the main language handler subsystem for RozWorld.
    /// </summary>
    public interface ILanguageSystem
    {
        /// <summary>
        /// Gets all the available languages (by their codes) as an IList&lt;string&gt; collection.
        /// </summary>
        IList<string> AvailableLanguages { get; }

        /// <summary>
        /// Gets all the available language packs as an IList&lt;string&gt; collection.
        /// </summary>
        IList<string> AvailablePacks { get; }


        /// <summary>
        /// Gets the language string of the specified ID from the default language pack.
        /// </summary>
        /// <param name="lid">The language string ID.</param>
        /// <returns>The string of the specified ID from the default language pack, "undefined" if it was not found.</returns>
        string GetLanguageString(ushort lid);

        /// <summary>
        /// Gets the language string of the specified ID from the given language pack.
        /// </summary>
        /// <param name="pack">The name of the language pack.</param>
        /// <param name="lid">The language string ID.</param>
        /// <returns>The string of the specified ID from the given language pack, "undefined" if it was not found.</returns>
        string GetLanguageString(string pack, ushort lid);

        /// <summary>
        /// Switches to the specified language.
        /// </summary>
        /// <param name="langCode">The language code.</param>
        /// <returns>True if the language was able to be switched to.</returns>
        bool SwitchLanguage(string langCode);
    }
}
