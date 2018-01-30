using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceFiles
{
    public class EnumResourceAttribute: Attribute
    {
        public Type ResourceType { get; private set; }

        public EnumResourceAttribute(Type resourceType)
        {
            ResourceType = resourceType;
        }

    }
}
