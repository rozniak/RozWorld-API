/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.ITextContainer -- RozWorld Client Interface Text Container Control
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Interface.Control
{
    /// <summary>
    /// Represents a control that contains text.
    /// </summary>
    public interface ITextContainer
    {
        /// <summary>
        /// Gets or sets the text that appears on this ITextContainer.
        /// </summary>
        string Text { get; set; }
    }
}
