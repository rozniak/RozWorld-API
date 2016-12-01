/**
 * Oddmatics.RozWorld.API.Client.Input.InputUpdateCallback -- RozWorld Client Input Update Callback
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

namespace Oddmatics.RozWorld.API.Client.Input
{
    /// <summary>
    /// Represents the method that will handle an input update.
    /// </summary>
    /// <param name="inputType">The input type being updated.</param>
    /// <param name="status">The new status of the input.</param>
    /// <param name="extraData">Extra data for the input update, should provide information regarding ports etc.</param>
    public delegate void InputUpdateCallback(InputType inputType, byte status, byte extraData);
}
