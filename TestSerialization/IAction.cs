using System.Runtime.Serialization;

namespace TestSerialization
{
    [DataContract]
    public abstract class IAction
    {
        public abstract void Execute();
    }
}
