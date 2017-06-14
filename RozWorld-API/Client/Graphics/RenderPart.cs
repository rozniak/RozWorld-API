/**
 * Oddmatics.RozWorld.API.Client.Interface.RenderPart -- RozWorld Client Renderer Task Part
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using Oddmatics.RozWorld.API.Generic;

namespace Oddmatics.RozWorld.API.Client.Graphics
{
    /// <summary>
    /// Represents an individual part of a render task that is used to construct the final operatable render task.
    /// </summary>
    public class RenderPart
    {
        /// <summary>
        /// Gets or sets the target triangle vertices to draw this part.
        /// </summary>
        public RwPoint[] DrawVertices { get; set; }

        /// <summary>
        /// Gets or sets the texture ID of this part.
        /// </summary>
        public int TextureId { get; set; }

        /// <summary>
        /// Gets or sets the UV vertices used to map the texture of this part.
        /// </summary>
        public RwPoint[] UvVetices { get; set; }


        /// <summary>
        /// Initialises a new instance of the RenderPart class.
        /// </summary>
        public RenderPart()
        {
            DrawVertices = new RwPoint[]
            {
                new RwPoint(0, 0),
                new RwPoint(0, 0),
                new RwPoint(0, 0)
            };

            TextureId = -1;

            UvVetices = new RwPoint[]
            {
                new RwPoint(0, 0),
                new RwPoint(0, 0),
                new RwPoint(0, 0)
            };
        }
    }
}
