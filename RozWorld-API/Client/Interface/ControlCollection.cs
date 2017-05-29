/**
 * Oddmatics.RozWorld.API.Client.Interface.Control.ControlCollection -- RozWorld Client Interface Control Collection Structure
 *
 * This source-code is part of the API for the RozWorld project by rozza of Oddmatics:
 * <<http://www.oddmatics.uk>>
 * <<http://roz.world>>
 * <<http://github.com/rozniak/RozWorld-API>>
 *
 * Sharing, editing and general licence term information can be found inside of the "LICENCE.MD" file that should be located in the root of this project's directory structure.
 */

using System;
using System.Collections;
using System.Collections.Generic;

namespace Oddmatics.RozWorld.API.Client.Interface
{
    /// <summary>
    /// Represents a collection of Control objects.
    /// </summary>
    public sealed class ControlCollection : ICloneable, ICollection, IEnumerable, IList
    {
        /// <summary>
        /// Gets the number of elements in the collection.
        /// </summary>
        public int Count
        {
            get { return Controls.Count; }
        }

        /// <summary>
        /// Gets a value indicating whether the collection has a fixed size.
        /// </summary>
        public bool IsFixedSize
        {
            get { return false; }
        }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();


        /// <summary>
        /// The underlying Dictionary collection containing key-value pairs of names to Control objects.
        /// </summary>
        private Dictionary<string, Control> Controls { get; set; }

        /// <summary>
        /// The owner IControlContainer object.
        /// </summary>
        private IControlContainer Owner { get; set; }


        /// <summary>
        /// Initializes a new instance of the ControlCollection class.
        /// </summary>
        /// <param name="owner">An IControlContainer representing the container that owns the control collection.</param>
        public ControlCollection(IControlContainer owner)
        {
            if (owner == null)
                throw new ArgumentNullException("ControlCollection.new: Parameter 'owner' cannot be null.");

            Owner = owner;
        }


        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        /// <summary>
        /// Adds the specified control to the control collection.
        /// </summary>
        /// <param name="control">The Control to add to the control collection.</param>
        public void Add(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("ControlCollection.Add: Parameter 'control' cannot be null.");

            if (String.IsNullOrEmpty(control.Name))
                throw new ArgumentException("ControlCollection.Add: The specified control does not have a name and cannot be added.");


            string lowKey = control.Name.ToLower();

            if (Controls.ContainsKey(lowKey))
                throw new ArgumentException("ControlCollection.Add: A control with the name '" + control.Name + "' already exists within the collection.");

            Controls.Add(lowKey, control);
        }

        /// <summary>
        /// Adds the specified control to the control collection.
        /// </summary>
        /// <param name="value">The Control to add to the control collection, cast as an object.</param>
        /// <returns>0 upon success.</returns>
        public int Add(object value)
        {
            if (value == null)
                throw new ArgumentNullException("ControlCollection.Add: Parameter 'value' cannot be null.");

            if (!value.GetType().IsSubclassOf(typeof(Control)))
                throw new ArgumentException("ControlCollection.Add: Parameter 'value' must be a subclass of Control.");
            
            Add((Control)value);

            return 0;
        }

        /// <summary>
        /// Removes all controls from the collection.
        /// </summary>
        public void Clear()
        {
            Controls.Clear();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
