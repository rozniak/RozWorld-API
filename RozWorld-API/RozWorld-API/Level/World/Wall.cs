/**
 * RozWorld-API.Level.World.Wall -- RozWorld Tile Wall
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Level.World
{
    public abstract class Wall
    {
        /// <summary>
        /// Gets the internal reference name of this wall.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the ID of this wall.
        /// </summary>
        public ushort ID
        {
            get { return ParentServer.GetWallID(Name); }
        }

        /// <summary>
        /// Gets or sets the parent server of this item.
        /// </summary>
        protected Server ParentServer
        {
            get { return _ParentServer; }
            set { if (_ParentServer != null) _ParentServer = value; }
        }
        private Server _ParentServer;
    }
}
