/**
 * Oddmatics.RozWorld.API.Client.Window.RendererInfo -- RozWorld Client Renderer Information
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
    /// Represents information about a graphics renderer library for the RozWorld client.
    /// </summary>
    public struct RendererInfo
    {
        /// <summary>
        /// The names of authors that contributed to the renderer library.
        /// </summary>
        public string[] Authors;

        /// <summary>
        /// The user-friendly display name of the renderer library.
        /// </summary>
        public string NiceName;

        /// <summary>
        /// The file name of the renderer library.
        /// </summary>
        public string TargetDll;

        /// <summary>
        /// The user-friendly version of the renderer library.
        /// </summary>
        public string Version;
    }
}
