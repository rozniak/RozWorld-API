/**
 * Oddmatics.RozWorld.API.Client.Interface.IInterfaceHandler -- RozWorld Client Interface Handler
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<https://oddmatics.uk>>
 * <<http://roz.world>>
 * <<https://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */
 
using System;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents the main interface handler for the RozWorld client.
    /// </summary>
    public interface IInterfaceHandler
    {
        /// <summary>
        /// Gets or sets the currently active form.
        /// </summary>
        Form FocusedForm { get; set; }

        /// <summary>
        /// Gets the child IForm instances of this IInterfaceHandler.
        /// </summary>
        IList<Form> Forms { get; }


        /// <summary>
        /// Factory method for creating controls from an interface within this API.
        /// </summary>
        /// <param name="controlInterface">The interface's Type.</param>
        /// <param name="name">The name to give the new instance.</param>
        /// <returns>A new IControl instance of the referred interface Type.</returns>
        Control CreateControlFromInterface(Type controlInterface, string name);

        /// <summary>
        /// Factory method for creating forms.
        /// </summary>
        /// <param name="name">The name to give the new instance.</param>
        /// <returns>A new IForm instance of the Type specified internally by the client implementation.</returns>
        Form CreateForm(string name);
    }
}
