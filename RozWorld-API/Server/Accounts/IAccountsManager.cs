﻿/**
 * Oddmatics.RozWorld.API.Server.Accounts.IAccountsManager -- RozWorld Server Accounts Manager
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Server.Accounts
{
    /// <summary>
    /// Represents an account manager for performing various functions on accounts.
    /// </summary>
    public interface IAccountsManager
    {
        /// <summary>
        /// Gets the amount of accounts stored.
        /// </summary>
        int AccountCount { get; }


        /// <summary>
        /// Deletes saved data of a given IAccount.
        /// </summary>
        /// <param name="account">The IAccount to delete.</param>
        /// <returns>True if the was deleted.</returns>
        bool DeleteAccount(IAccount account);

        /// <summary>
        /// Deletes the saved data of an account of the given name.
        /// </summary>
        /// <param name="name">The name of the account to delete.</param>
        /// <returns>True if the account existed and was deleted.</returns>
        bool DeleteAccount(string name);

        /// <summary>
        /// Gets the IAccount associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the IAccount to get.</param>
        /// <returns>The IAccount instance obtained from the given name, null if the name has no association.</returns>
        IAccount GetAccount(string name);

        /// <summary>
        /// Renames an IAccount to the specified new name.
        /// </summary>
        /// <param name="account">The IAccount instance to rename.</param>
        /// <param name="newName">The new name of the IAccount.</param>
        /// <returns>True if the IAccount was renamed.</returns>
        bool RenameAccount(IAccount account, string newName);

        /// <summary>
        /// Saves all account data to the disk.
        /// </summary>
        void Save();
    }
}
