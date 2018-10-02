/**
 * Oddmatics.RozWorld.API.Client.Window.TextRendererInstruction -- RozWorld Client Text Renderer Instruction
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents a text instruction for the renderer.
    /// </summary>
    public sealed class TextRendererInstruction : AbstractRendererInstruction
    {
        /// <summary>
        /// Gets or sets the ID of the font resource to use when rendering the text.
        /// </summary>
        public uint FontId { get; set; }

        /// <summary>
        /// Gets the type of instruction this is.
        /// </summary>
        public override RenderInstructionType InstructionType
        {
            get { return RenderInstructionType.Text; }
        }

        /// <summary>
        /// Gets or sets the text to render.
        /// </summary>
        public string Text { get; set; }


        /// <summary>
        /// Initializes a new instance of the TextRendererInstruction class.
        /// </summary>
        public TextRendererInstruction()
        {
            FontId = 0;
            Text = String.Empty;
        }
    }
}
