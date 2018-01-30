using ResourceFiles.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceFiles
{
    [EnumResource(typeof(GenderEnumResource))]
    public enum Gender
    {
        Male, Female, Unspecified
    }
}
