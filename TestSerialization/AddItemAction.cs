using System;
using System.Runtime.Serialization;

namespace TestSerialization
{
    [DataContract]
    class AddItemAction : IAction
    {
        [DataMember]
        public string text { get; private set; }

        public AddItemAction()
        {}
        public AddItemAction(string text)
        {
            this.text = text;
        }

        public override void Execute()
        {
            Console.WriteLine("Item action: " + text);
        }
    }
}
