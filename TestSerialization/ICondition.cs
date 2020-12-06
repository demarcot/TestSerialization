using System.Runtime.Serialization;

namespace TestSerialization
{
    [DataContract]
    public abstract class ICondition
    {
        public abstract bool IsValid();
    }
}
