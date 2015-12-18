/**
 * RozWorld-API.Thing.Item -- RozWorld Item
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace RozWorld_API.Thing
{
    public abstract class Item
    {
        /// <summary>
        /// Gets whether this item allows multiple of itself to be contained in a single slot.
        /// </summary>
        public abstract bool AllowMultiple { get; }

        /// <summary>
        /// Gets the internal reference name of this item.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the language string identifier of this item that is shown in the client's GUI.
        /// </summary>
        public abstract string LanguageString { get; }

        /// <summary>
        /// Gets the type of this item.
        /// </summary>
        public abstract ItemType Type { get; }

        /// <summary>
        /// Gets the ID of this item.
        /// </summary>
        public ushort ID
        {
            get { return ParentServer.GetItemID(Name); } 
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
