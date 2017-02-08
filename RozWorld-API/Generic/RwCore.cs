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
        /// </summary>
        /// <remarks>Setting this must be done at initialisation stage, this can't be set if an instance already exists.</remarks>
        public static IRwClient Client
        {
            get
            {
                if (InstanceType == RwInstanceType.ClientOnly || InstanceType == RwInstanceType.Both)
                    return _Client;
                else
                    throw new InvalidOperationException("RwCore.Client.Get: Illegal client call! This RozWorld instance is not a client.");
            }
            set
            {
                if (InstanceType != RwInstanceType.ClientOnly && InstanceType != RwInstanceType.Both)
                    throw new InvalidOperationException("RwCore.Client.Set: Cannot set client, this RozWorld instance is not a client.");
                else if (_Client != null)
                    throw new InvalidOperationException("RwCore.Client.Set: Cannot set client, it is not null.");
                else
                    _Client = value;
            }
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
        /// <remarks>This must be set before the server or client instances.</remarks>
        public static RwInstanceType InstanceType
        {
            get { return _InstanceType; }
            set
            {
                if (_InstanceType != RwInstanceType.Unset)
                    throw new InvalidOperationException("RwCore.InstanceType.Set: Cannot set instance type, it has already been set.");
                else if (value == RwInstanceType.Unset)
                    throw new InvalidOperationException("RwCore.InstanceType.Set: Cannot set instance type to unset.");
                else
                    _InstanceType = value;
            }
        }
        private static RwInstanceType _InstanceType = RwInstanceType.Unset;
        
        /// <summary>
        /// Gets or sets the shared ILanguageSystem instance for RozWorld.
        /// </summary>
        /// <remarks>Setting this must be done at initialisation stage, this can't be set if an instance already exists.</remarks>
        public static ILanguageSystem LanguageSystem
        {
            get { return _LanguageSystem; }
            set { if (_LanguageSystem == null) _LanguageSystem = value; else
                throw new InvalidOperationException("RwCore.LanguageSystem.Set: Cannot set language system, it is not null."); }
        }
        private static ILanguageSystem _LanguageSystem;

        /// <summary>
        /// Gets or sets the current RozWorld server instance.
        /// </summary>
        /// <remarks>Setting this must be done at initialisation stage, this can't be set if an instance already exists.</remarks>
        public static IRwServer Server
        {
            get
            {
                if (InstanceType == RwInstanceType.ServerOnly || InstanceType == RwInstanceType.Both)
                    return _Server;
                else
                    throw new InvalidOperationException("RwCore.Server.Get: Illegal server call! This RozWorld instance is not a server.");
            }
            set
            {
                if (InstanceType != RwInstanceType.ServerOnly && InstanceType != RwInstanceType.Both)
                    throw new InvalidOperationException("RwCore.Server.Set: Cannot set server, this RozWorld instance is not a server.");
                else if (_Server != null)
                    throw new InvalidOperationException("RwCore.Server.Set: Cannot set server, it is not null.");
                else
                    _Server = value;
            }
        }
        private static IRwServer _Server;
    }
}
