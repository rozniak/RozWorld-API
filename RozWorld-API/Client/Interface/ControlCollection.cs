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
using System.Linq;

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

        /// <summary>
        /// This property is not intended to be used in your code.
        /// </summary>
        public bool IsSynchronized => throw new NotImplementedException();

        /// <summary>
        /// This property is not intended to be used in your code.
        /// </summary>
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


        /// <summary>
        /// Gets or sets the control associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the Control to get or set.</param>
        /// <returns>The Control associated with the specified name. If the specified key is not found, both get and set operations will throw a KeyNotFoundException.</returns>
        public Control this[string name]
        {
            get
            {
                string lowKey = name.ToLower();

                if (Controls.ContainsKey(lowKey))
                    return Controls[lowKey];

                throw new KeyNotFoundException("ControlCollection[string].get: No control of the specified name was found within the collection.");
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("ControlCollection[string].set: Cannot assign control to null value.");

                string lowKey = name.ToLower();
                string lowName = value.Name.ToLower();

                if (!Controls.ContainsKey(lowKey))
                    throw new KeyNotFoundException("ControlsCollection[string].set: No control of the specified name was found within the collection.");

                if (lowKey != lowName)
                {
                    if (Controls.ContainsKey(lowName))
                        throw new InvalidOperationException("ControlCollection[string].set: New Control value has a different name, however the name is already in use by another Control in the collection.");

                    Controls.Remove(lowKey);
                    Controls.Add(lowName, value);
                }
                else
                    Controls[lowKey] = value;
            }
        }

        /// <summary>
        /// This indexer is not intended to be used in your code.
        /// </summary>
        /// <param name="index">Do not use.</param>
        /// <returns>This indexer will throw a NotImplementedException if called.</returns>
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
        /// This function is not intended to be used in your code.
        /// </summary>
        /// <param name="value">Do not use.</param>
        /// <returns>This function will throw a NotImplementedException if called.</returns>
        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds an array of control objects to the collection.
        /// </summary>
        /// <param name="controls">An array of Control objects to add to the collection.</param>
        /// <returns>Any Control objects that could not be added to the collection, as an IList&lt;Control&gt; collection.</returns>
        public IList<Control> AddRange(Control[] controls)
        {
            var leftovers = new List<Control>();

            foreach (Control control in controls)
            {
                if (String.IsNullOrEmpty(control.Name))
                {
                    leftovers.Add(control);
                    continue;
                }

                string lowKey = control.Name.ToLower();

                if (Controls.ContainsKey(lowKey))
                {
                    leftovers.Add(control);
                    continue;
                }

                Controls.Add(lowKey, control);
            }

            return leftovers.AsReadOnly();
        }

        /// <summary>
        /// Removes all controls from the collection.
        /// </summary>
        public void Clear()
        {
            Controls.Clear();
        }

        /// <summary>
        /// Creates an exact copy of this ControlCollection.
        /// </summary>
        /// <returns>The ControlCollection this method makes, cast as an object.</returns>
        public object Clone()
        {
            var clone = new ControlCollection(this.Owner);

            clone.AddRange(Controls.Values.ToArray());

            return clone;
        }

        /// <summary>
        /// Determines whether the specified control is a member of the collection.
        /// </summary>
        /// <param name="value">The Control to locate inside the collection, cast as an object.</param>
        /// <returns>True if the Control is a member of the collection.</returns>
        public bool Contains(object value)
        {
            return Controls.ContainsValue((Control)value);
        }

        /// <summary>
        /// Copies the entire contents of this collection to a compatible one-dimensional Array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements copied from the current collection. The array must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in array at which copying begins.</param>
        public void CopyTo(Array array, int index)
        {
            Control[] controls = Controls.Values.ToArray();

            Array.Copy(controls, 0, array, index, controls.Length);
        }

        /// <summary>
        /// Retrieves a reference to an enumerator object that is used to iterate over a ControlCollection.
        /// </summary>
        /// <returns>An IEnumerator.</returns>
        public IEnumerator GetEnumerator()
        {
            return Controls.GetEnumerator();
        }

        /// <summary>
        /// This function is not intended to be used in your code.
        /// </summary>
        /// <param name="value">Do not use.</param>
        /// <returns>This function will throw a NotImplementedException if called.</returns>
        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This function is not intended to be used in your code.
        /// </summary>
        /// <param name="value">Do not use.</param>
        /// <returns>This function will throw a NotImplementedException if called.</returns>
        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified control from the control collection.
        /// </summary>
        /// <param name="value">The Control to remove from the ControlCollection.</param>
        public void Remove(Control value)
        {
            string lowKey = value.Name.ToLower();

            if (!Controls.ContainsKey(lowKey) || Controls[lowKey] != value)
                throw new InvalidOperationException("ControlCollection.Remove: The specified Control object does not exist in this collection.");

            Controls.Remove(lowKey);
        }

        /// <summary>
        /// This function is not intended to be used in your code.
        /// </summary>
        /// <param name="value">Do not use.</param>
        /// <returns>This function will throw a NotImplementedException if called.</returns>
        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the specified control from the control collection.
        /// </summary>
        /// <param name="value">The name of the control to remove from the ControlCollection.</param>
        public void Remove(string value)
        {
            string lowKey = value.ToLower();

            if (!Controls.ContainsKey(lowKey))
                throw new InvalidOperationException("ControlCollection.Remove: The specified name does not correspond with any control that exists within this collecton.");

            Controls.Remove(lowKey);
        }

        /// <summary>
        /// This function is not intended to be used in your code.
        /// </summary>
        /// <param name="index">Do not use.</param>
        /// <returns>This function will throw a NotImplementedException if called.</returns>
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
