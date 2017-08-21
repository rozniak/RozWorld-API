/**
* Oddmatics.RozWorld.API.Server.Accounts.AccountRecord -- RozWorld Account Record
*
* This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
* <<https://oddmatics.uk>>
* <<http://roz.world>>
* <<https://github.com/rozniak/RozWorld-API>>
*
* Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
*/

using System;
using System.Net;

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents a record to store account information.
    /// </summary>
    public sealed class AccountRecord
    {
        /// <summary>
        /// The date that this account was created.
        /// </summary>
        public DateTime CreationDate;

        /// <summary>
        /// The IP address that created this account.
        /// </summary>
        public IPAddress CreationIP;

        /// <summary>
        /// The filename of the player data file associated with this account.
        /// </summary>
        public string DataFilename;

        /// <summary>
        /// The display name of this account.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// The unique ID used for this record.
        /// </summary>
        public int Id;

        /// <summary>
        /// The SHA-256'd password hash of this account.
        /// </summary>
        public byte[] PasswordHash
        {
            get { return _PasswordHash; }
            set
            {
                if (value.Length == 0 || value.Length == 32)
                    _PasswordHash = value;
                else
                    throw new ArgumentException("AccountRecord.PasswordHash.Set: Invalid hash length.");
            }
        }
        private byte[] _PasswordHash;

        /// <summary>
        /// The filename of the permissions file associated with this account.
        /// </summary>
        public string PermissionsFilename;

        /// <summary>
        /// The username of this account.
        /// </summary>
        public string Username;
    }
}
