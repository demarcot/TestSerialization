using System;
using System.Collections.Generic;

namespace TestSerialization
{
    public static class KnownTypeUtil
    {
        private static readonly List<Type> KnownDialogTypes = new List<Type>
        {
            // -- Actions --
            typeof(AddItemAction), typeof(ModifyHealthAction),

            // -- Conditions --
            typeof(ItemQtyCondition), typeof(ReqHealthCondition)
        };

        public static List<Type> GetKnownDialogTypes()
        {
            return KnownDialogTypes;
        }

        public static void AddKnownDialogType(Type t)
        {
            KnownDialogTypes.Add(t);
        }
    }
}
