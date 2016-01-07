﻿/**
 * RozWorld-API.Mod.Plugin -- RozWorld Server Plugin
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Mod
{
    public abstract class Plugin
    {
        /// <summary>
        /// Gets the name of this plugin.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the version of this plugin.
        /// </summary>
        public abstract ushort Version { get; }

        /// <summary>
        /// Gets or sets the parent server of this item.
        /// </summary>
        protected Server ParentServer
        {
            get { return _ParentServer; }
            set { if (_ParentServer != null) _ParentServer = value; }
        }
        private Server _ParentServer;


        /// <summary>
        /// Method to be called when the server is starting up.
        /// </summary>
        public virtual void Load() { }

        /// <summary>
        /// Method to be called when the server is shutting down.
        /// </summary>
        public virtual void Unload() { }
    }
}
