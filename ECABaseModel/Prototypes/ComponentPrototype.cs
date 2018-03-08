﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ECABaseModel.Prototypes
{
    /// <summary>
    /// Component definition that can not be modified.
    /// </summary>
    public abstract class ComponentPrototype
    {
        /// <summary>
        /// GUID that uniquely identifies this component definition.
        /// </summary>
        public Guid Guid { get; private set; }

        /// <summary>
        /// Name of the component.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// A collection of attribute definitions.
        /// </summary>
        public abstract ReadOnlyCollection<AttributePrototype> AttributeDefinitions { get; }

        /// <summary>
        /// Returns a attribute definition by its name or throws KeyNotFoundException if the attribute is not defined.
        /// </summary>
        /// <param name="attributeName">Attribute name.</param>
        /// <returns>Attribute definition.</returns>
        public abstract AttributePrototype this[string attributeName] { get; }

        /// <summary>
        /// Verifies whether this component definition contains a definition for an attribute with a given name.
        /// </summary>
        /// <param name="attributeName">Attribute name.</param>
        /// <returns>True if definition for such attribute is present, false otherwise.</returns>
        public abstract bool ContainsAttributeDefinition(string attributeName);

        internal ComponentPrototype(string name, Guid guid)
        {
            Guid = guid;
            Name = name;
        }

        // Needed by persistence plugin.
        internal ComponentPrototype() { }
    }
}
