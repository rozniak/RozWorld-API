/**
 * Oddmatics.RozWorld.API.Client.IRwClient -- RozWorld Client
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
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
        Dictionary<byte, RwSize> DisplayResolutions { get; }

        /// <summary>
        /// Gets the input handler of this client.
        /// </summary>
        IInputHandler Input { get; }

        /// <summary>
        /// Gets the interface handler of this client.
        /// </summary>
        IInterfaceHandler Interface { get; }

        /// <summary>
        /// Gets the logger this client is using.
        /// </summary>
        ILogger Logger { get; }

        /// <summary>
        /// Gets the target RozWorld version of this client implementation.
        /// </summary>
        string RozWorldVersion { get; }

        /// <summary>
        /// Gets the root directory that relative texture paths stem from.
        /// </summary>
        string TexturesRoot { get; }
    }
}
