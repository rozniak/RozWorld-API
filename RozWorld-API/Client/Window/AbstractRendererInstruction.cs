/**
 * Oddmatics.RozWorld.API.Client.Window.AbstractRendererInstruction -- RozWorld Client Abstracted Renderer Instruction
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents an abstracted renderer instruction.
    /// </summary>
    public abstract class AbstractRendererInstruction
    {
        /// <summary>
        /// Gets a unique key string that can identify the last version of this instruction for use when caching.
        /// </summary>
        public ulong CacheKey { get; protected set; }

        /// <summary>
        /// Gets the type of instruction this is.
        /// </summary>
        public abstract RenderInstructionType InstructionType { get; }
    }
}
