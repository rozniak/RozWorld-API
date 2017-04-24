/**
* Oddmatics.RozWorld.API.Server.Accounts.IAccountsManager -- RozWorld Server Accounts Manager
*
* This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
* <<http://www.oddmatics.uk>>
* <<http://roz.world>>
* <<http://github.com/rozniak/RozWorld-API>>
*
* Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
*/

using Oddmatics.RozWorld.API.Generic;

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
        /// <returns>Success if the account existed was deleted.</returns>
        RwResult DeleteAccount(IAccount account);

        /// <summary>
        /// Deletes the saved data of an account of the given name.
        /// </summary>
        /// <param name="name">The name of the account to delete.</param>
        /// <returns>Success if the account existed and was deleted.</returns>
        RwResult DeleteAccount(string name);

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
        /// <returns>Success if the account was renamed.</returns>
        RwResult RenameAccount(IAccount account, string newName);

        /// <summary>
        /// Updates saved account information when fields are updated.
        /// </summary>
        /// <param name="account">The IAccount instance to update.</param>
        /// <returns>Success if the account was updated.</returns>
        RwResult UpdateAccount(IAccount account);

        /// <summary>
        /// Saves all account data to the disk.
        /// </summary>
        /// <returns>Success if the account data was saved successfully.</returns>
        RwResult Save();
    }
}
