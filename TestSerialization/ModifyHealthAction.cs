using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestSerialization
{
    [DataContract]
    class ModifyHealthAction : IAction
    {
        [DataMember]
        private int healthDelta;

        public ModifyHealthAction() { }
        public ModifyHealthAction(int healthDelta)
        {
            this.healthDelta = healthDelta;
        }

        public override void Execute()
        {
            Console.WriteLine("Health action: " + healthDelta);
        }
    }
}
