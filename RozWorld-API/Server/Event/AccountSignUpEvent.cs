/**
 * Oddmatics.RozWorld.API.Server.Event.AccountSignUpEvent -- RozWorld Server Account Sign Up Event
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Net;

namespace Oddmatics.RozWorld.API.Server.Event
{
    /// <summary>
    /// Represents the method that will handle the AccountSignUp event of an IRwServer.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An AccountSignUpEventArgs object that contains event data.</param>
    public delegate void AccountSignUpEventHandler(object sender, AccountSignUpEventArgs e);


    /// <summary>
    /// Provides data for the IRwServer.AccountSignUp event.
    /// </summary>
    public class AccountSignUpEventArgs : EventArgs, ICancellable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the event should be canceled.
        /// </summary>
        public bool Cancel { get; set; }

        /// <summary>
        /// Gets the source IPAddress of the sign up.
        /// </summary>
        public IPAddress SourceIP { get; private set; }

        /// <summary>
        /// Gets the username of the account being registered.
        /// </summary>
        public string Username { get; private set; }


        /// <summary>
        /// Initialises a new instance of the PlayerChatEventArgs class with a source IPAddress and username.
        /// </summary>
        /// <param name="sourceIP">The source IPAddress that sent the sign up request.</param>
        /// <param name="username">The username being registered.</param>
        public AccountSignUpEventArgs(IPAddress sourceIP, string username)
        {
            SourceIP = sourceIP;
            Username = username;
        }
    }
}
