/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.IPictureBox -- RozWorld Client Interface Static Picture Box
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
    /// Represents a static picture box control on the interface.
    /// </summary>
    public interface IPictureBox : IControl
    {
        /// <summary>
        /// The sizing mode to use on the image.
        /// </summary>
        PictureBoxSizeMode SizeMode { get; set; }

        /// <summary>
        /// The source image filepath to use.
        /// </summary>
        string Source { get; set; }
    }
}
