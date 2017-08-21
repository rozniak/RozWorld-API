/**
 * Oddmatics.RozWorld.API.Server.Event.ICancellable -- RozWorld Server Cancellable Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents a cancellable event.
    /// </summary>
    public interface ICancellable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the event should be cancelled.
        /// </summary>
        bool Cancel { get; set; }
    }
}
