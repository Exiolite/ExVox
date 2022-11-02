using System;
using JetBrains.Annotations;

namespace Attributes
{
    [MeansImplicitUse(ImplicitUseKindFlags.Assign)]
    [AttributeUsage(AttributeTargets.Field)]
    public class GetComponentAttribute : Attribute
    {
    }
}
