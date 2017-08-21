/**
 * Oddmatics.RozWorld.API.Client.RwResource -- RozWorld Client Resource Request
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Client
{
    /// <summary>
    /// Represents a RozWorld resource file to be loaded.
    /// </summary>
    public class RwResource
    {
        /// <summary>
        /// The classification string for audio resources.
        /// </summary>
        public const string CLASSIFICATION_AUDIO = "AUDIO";

        /// <summary>
        /// The classification string for graphic resources.
        /// </summary>
        public const string CLASSIFICATION_GRAPHIC = "GRAPHIC";


        /// <summary>
        /// Gets or sets the classification for this resource.
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Gets or sets the identifier that this resource will use when loaded.
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the filepath to this resource.
        /// </summary>
        public string Path { get; set; }


        /// <summary>
        /// Initialises a new instance of the RwResource class.
        /// </summary>
        public RwResource()
        {
            Classification = String.Empty;
            Identifier = String.Empty;
            Path = String.Empty;
        }
    }
}
