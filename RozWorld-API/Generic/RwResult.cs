/**
 * Oddmatics.RozWorld.API.Generic.RwResult -- RozWorld Method Result
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Specifies constants defining the result of a method.
    /// 
    /// When transmitting this enum over the network, cast it as an unsigned short (UInt16).
    /// </summary>
    public enum RwResult
    {
        #region General Status Codes

        /// <summary>
        /// The operation was a success.
        /// </summary>
        Success = 0,

        /// <summary>
        /// The operation failed.
        /// </summary>
        GeneralFailure = 1,

        /// <summary>
        /// The requested operation is not implemented.
        /// </summary>
        NotImplemented = 2,

        #endregion


        #region I/O Status Codes

        /// <summary>
        /// The requested file could not be found.
        /// </summary>
        FileNotFound = 5,

        /// <summary>
        /// The requested file could not be read because the format is invalid or unsupported.
        /// </summary>
        InvalidFileFormat = 6,

        /// <summary>
        /// The requested file could not be loaded because another asset is already using the same identifier.
        /// </summary>
        DuplicateAssetIdentifier = 7,

        #endregion


        #region Account Status Codes

        /// <summary>
        /// The account name has already been taken.
        /// </summary>
        AccountNameTaken = 10,

        /// <summary>
        /// The account name contains illegal characters or otherwise was not acceptable.
        /// </summary>
        AccountNameInvalid = 11,

        /// <summary>
        /// The password hash provided was invalid.
        /// </summary>
        PasswordInvalid = 12,

        /// <summary>
        /// The client has too many accounts and the request will not be fulfilled.
        /// </summary>
        TooManyAccounts = 13,

        /// <summary>
        /// The client is banned.
        /// </summary>
        Banned = 14,

        /// <summary>
        /// The login credentials provided were incorrect.
        /// </summary>
        IncorrectLogin = 15,

        /// <summary>
        /// The amount of login details has been exceeded and the account is currently in the lockout period.
        /// </summary>
        AttemptsExpired = 16,

        /// <summary>
        /// The date/time of the password hash used is outside of the acceptable range.
        /// </summary>
        HashtimeInvalid = 17,

        /// <summary>
        /// The account or client is not on the server whitelist.
        /// </summary>
        NotOnWhitelist = 18,

        /// <summary>
        /// The token provided was not correct.
        /// </summary>
        BadToken = 19,

        /// <summary>
        /// The account operation cannot be performed it is logged on currently, it must be logged off.
        /// </summary>
        MustBeOffline = 20,

        #endregion

        #region System Status Codes

        /// <summary>
        /// The system is not in a state that is ready to perform the requested operation.
        /// </summary>
        NotReady = 100

        #endregion
    }
}
