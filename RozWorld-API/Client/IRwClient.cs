/**
 * Oddmatics.RozWorld.API.Client.IRwClient -- RozWorld Client
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Client.Input;
using Oddmatics.RozWorld.API.Client.Interface;
using Oddmatics.RozWorld.API.Generic;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a RozWorld client.
    /// </summary>
    public interface IRwClient
    {
        /// <summary>
        /// Gets the name of this client implementation.
        /// </summary>
        string ClientName { get; }

        /// <summary>
        /// Gets the version of this client implementation.
        /// </summary>
        string ClientVersion { get; }

        /// <summary>
        /// Gets the window title to be used in this implementation.
        /// </summary>
        string ClientWindowTitle { get; }

        /// <summary>
        /// Gets the display resolutions of screens that have been configured.
        /// </summary>
        Dictionary<byte, Size> DisplayResolutions { get; }

        /// <summary>
        /// Gets the IInputHandler instance for this IRwClient.
        /// </summary>
        IInputHandler Input { get; }

        /// <summary>
        /// Gets the IInterfaceHandler instance for this IRwClient.
        /// </summary>
        IInterfaceHandler Interface { get; }

        /// <summary>
        /// Gets the logger this IRwClient is using.
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// Gets the target RozWorld version of this client implementation.
        /// </summary>
        string RozWorldVersion { get; }
    }
}
