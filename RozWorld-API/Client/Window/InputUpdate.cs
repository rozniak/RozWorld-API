/**
 * Oddmatics.RozWorld.API.Client.Window.InputUpdate -- RozWorld Client Input Update
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
using System.Linq;

namespace Oddmatics.RozWorld.API.Client.Window
{
    /// <summary>
    /// Represents an input update from the RozWorld client window manager.
    /// </summary>
    public sealed class InputUpdate
    {
        /// <summary>
        /// Gets the current inputs that are pressed.
        /// </summary>
        public IList<string> DownedInputs { get; private set; }

        /// <summary>
        /// Gets the value that indicates whether this input update is read-only.
        /// </summary>
        public bool IsReadOnly { get; private set; }

        /// <summary>
        /// Gets inputs that have been pressed since the last state update.
        /// </summary>
        public IList<string> NewPresses { get; private set; }

        /// <summary>
        /// Gets inputs that have been released since the last state update.
        /// </summary>
        public IList<string> NewReleases { get; private set; }


        /// <summary>
        /// The collection of currently pressed inputs.
        /// </summary>
        private List<string> ActiveDownedInputs { get; set; }

        /// <summary>
        /// The collection of previously pressed inputs.
        /// </summary>
        private IList<string> LastDownedInputs { get; set; }


        /// <summary>
        /// Initializes a new instance of the InputUpdate class.
        /// </summary>
        public InputUpdate(IList<string> lastDownedInputs = null)
        {
            ActiveDownedInputs = new List<string>();
            DownedInputs = new List<string>().AsReadOnly();
            IsReadOnly = false;
            LastDownedInputs = lastDownedInputs;
            NewPresses = new List<string>().AsReadOnly();
            NewReleases = new List<string>().AsReadOnly();
        }


        /// <summary>
        /// Performs a comparison of this input update versus the last, and finalizes the state so no further reports can be made.
        /// </summary>
        public void FinalizeForReporting()
        {
            if (IsReadOnly)
                throw new InvalidOperationException("This input update state is current read-only and cannot be modified.");

            // Set up downed inputs
            //
            DownedInputs = new List<string>(ActiveDownedInputs).AsReadOnly();

            // Set up new presses
            //
            var newPresses = LastDownedInputs == null ?
                ActiveDownedInputs :
                ActiveDownedInputs.Except(LastDownedInputs);

            NewPresses = new List<string>(newPresses).AsReadOnly();

            // Set up new releases
            //
            var newReleases = LastDownedInputs == null ?
                new List<string>() :
                LastDownedInputs.Except(ActiveDownedInputs);

            NewReleases = new List<string>(newReleases).AsReadOnly();


            IsReadOnly = true;
        }

        /// <summary>
        /// Reports an input press.
        /// </summary>
        /// <param name="input">The fully-qualified input name.</param>
        public void ReportPress(string input)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("This input update state is currently read-only and cannot be modified.");

            if (!ActiveDownedInputs.Contains(input))
                ActiveDownedInputs.Add(input);
        }

        /// <summary>
        /// Reports an input release.
        /// </summary>
        /// <param name="input">The fully-qualified input name.</param>
        public void ReportRelease(string input)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("This input update state is current read-only and cannot be modified.");

            if (ActiveDownedInputs.Contains(input))
                ActiveDownedInputs.Remove(input);
        }
    }
}
