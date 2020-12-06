using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestSerialization
{
    [DataContract]
    class ItemQtyCondition : ICondition
    {
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
