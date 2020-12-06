using System;
using System.Collections.Generic;

namespace TestSerialization
{
    public static class KnowTypeUtil
    {
        public static List<Type> GetKnownDialogTypes()
        {
            return new List<Type> {
                // -- Actions --
                typeof(AddItemAction), typeof(ModifyHealthAction),

                // -- Conditions --
                typeof(ItemQtyCondition), typeof(ReqHealthCondition)
            };
        }
    }
}
