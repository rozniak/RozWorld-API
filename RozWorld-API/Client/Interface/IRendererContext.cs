﻿/**
 * Oddmatics.RozWorld.API.Client.Interface.IRendererContext -- RozWorld Client Renderer Context
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a renderer context to be used by interface components.
    /// </summary>
    public interface IRendererContext
    {
        IRenderTask CreateTextureTask();
    }
}
