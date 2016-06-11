/**
 * Oddmatics.RozWorld.API.Client.IRenderer -- RozWorld Client Renderer
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a graphics renderer for the RozWorld client.
    /// </summary>
    public interface IRenderer
    {
        // This is unfinished - hence no docs yet

        bool Initialised { get; }
        void Initialise();
        byte WindowCount { get; }
        void SetWindows(byte count);
    }
}
