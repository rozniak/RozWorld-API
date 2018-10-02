/**
 * Oddmatics.RozWorld.API.Client.Window.FontInfo -- RozWorld Client Font Information
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents abstracted font information
    /// </summary>
    public struct FontInfo
    {
        /// <summary>
        /// Gets or sets the family name of the font.
        /// </summary>
        public string FamilyName;

        /// <summary>
        /// Gets or sets the size in points.
        /// </summary>
        public int Size;


        /// <summary>
        /// Initializes a new instance of the FontInfo class.
        /// </summary>
        /// <param name="familyName">The</param>
        /// <param name="size"></param>
        public FontInfo(string familyName, int size)
        {
            FamilyName = familyName;
            Size = size;
        }
    }
}
