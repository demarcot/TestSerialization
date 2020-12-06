using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace TestSerialization
{
    public static class KnownTypeUtil
    {
        private static readonly ImmutableList<Type> KnownDialogTypes = ImmutableList<Type>.Empty.AddRange(
            new List<Type>
            {
                // -- Actions --
                typeof(AddItemAction), typeof(ModifyHealthAction),

                // -- Conditions --
                typeof(ItemQtyCondition), typeof(ReqHealthCondition)
            }
        );

        public static ImmutableList<Type> GetKnownDialogTypes()
        {
            return KnownDialogTypes;
        }
    }
}
