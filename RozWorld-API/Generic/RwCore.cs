/**
 * Oddmatics.RozWorld.API.Generic.RwCore -- RozWorld Core
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Client;
using Oddmatics.RozWorld.API.Generic.Language;
using Oddmatics.RozWorld.API.Server;
using System;

namespace Oddmatics.RozWorld.API.Generic
{
    /// <summary>
    /// Represents the RozWorld core systems for handling the client and server instances.
    /// </summary>
    public static class RwCore
    {
        /// <summary>
        /// Gets or sets the current RozWorld client instance.
        /// 
        /// Setting this must be done at initialisation stage, this can't be set if an instance already exists.
        /// </summary>
        public static IRwClient Client
        {
            get { return _Client; }
            set { if (_Client == null) _Client = value; else
                    throw new InvalidOperationException("RwCore.Client.Set: Cannot set client, it is not null."); }
        }
        private static IRwClient _Client;

        /// <summary>
        /// Gets the unified game core instance.
        /// </summary>
        public static GameCore Game { get { return _Game; } }
        private static GameCore _Game = new GameCore();

        /// <summary>
        /// Gets or sets the instance type for this RozWorld instance.
        /// </summary>
        public static RwInstanceType InstanceType
        {
            get { return _InstanceType; }
            set
            {
                if (_InstanceType != RwInstanceType.Unset)
                    throw new InvalidOperationException("RwCore.InstanceType.Set: Cannot set instance type, it has already been set.");

                if (value == RwInstanceType.Unset)
                    throw new InvalidOperationException("RwCore.InstanceType.Set: Cannot set instance type to unset.");

                _InstanceType = value;
            }
        }
        private static RwInstanceType _InstanceType = RwInstanceType.Unset;
        
        /// <summary>
        /// Gets or sets the shared ILanguageSystem instance for RozWorld.
        /// 
        /// Setting this must be done at initialisation stage, this can't be set if an instance already exists.
        /// </summary>
        public static ILanguageSystem LanguageSystem
        {
            get { return _LanguageSystem; }
            set { if (_LanguageSystem == null) _LanguageSystem = value; else
                throw new InvalidOperationException("RwCore.LanguageSystem.Set: Cannot set language system, it is not null."); }
        }
        private static ILanguageSystem _LanguageSystem;

        /// <summary>
        /// Gets or sets the current RozWorld server instance.
        /// 
        /// Setting this must be done at initialisation stage, this can't be set if an instance already exists.
        /// </summary>
        public static IRwServer Server
        {
            get { return _Server; }
            set { if (_Server == null) _Server = value; else
                throw new InvalidOperationException("RwCore.Server.Set: Cannot set server, it is not null."); }
        }
        private static IRwServer _Server;
    }
}
