/**
 * Oddmatics.RozWorld.API.Client.RendererInfo -- RozWorld Client Renderer Information
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents information regarding a graphics renderer for the RozWorld client.
    /// </summary>
    public struct RendererInfo
    {
        /// <summary>
        /// Gets the author of the renderer.
        /// </summary>
        public string Author { get; private set; }

        /// <summary>
        /// Gets the description about the renderer.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Gets the internal version number of the renderer
        /// </summary>
        public int InternalVersion { get; private set; }

        /// <summary>
        /// Gets the name of the renderer.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Type object used to create the renderer from.
        /// </summary>
        public Type RendererType { get; private set; }

        /// <summary>
        /// Gets whether this RendererInfo is valid.
        /// </summary>
        public bool Valid { get; private set; }

        /// <summary>
        /// Gets the nice version string of the renderer.
        /// </summary>
        public string Version { get; private set; }


        /// <summary>
        /// Initialises a new instance of the RendererInfo class with information about a renderer.
        /// </summary>
        /// <param name="name">The name of the renderer.</param>
        /// <param name="version">The nice version string for the renderer.</param>
        /// <param name="internalVersion">The internal version number of the renderer.</param>
        /// <param name="author">The author of the renderer.</param>
        /// <param name="description">A description about the renderer.</param>
        /// <param name="rendererType">The Type object to use to create the renderer from.</param>
        public RendererInfo(string name, string version, int internalVersion, string author, string description, Type rendererType)
            : this()
        {
            Name = name;
            Version = version;

            if (internalVersion > 0)
                InternalVersion = internalVersion;

            Author = author;
            Description = description;

            if (rendererType == typeof(Renderer))
            {
                RendererType = rendererType;
                Valid = true;
            }
        }
    }
}
