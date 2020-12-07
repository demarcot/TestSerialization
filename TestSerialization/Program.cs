using System;

namespace TestSerialization
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Dialog dialog1 = new Dialog();
            dialog1.AddAction(new AddItemAction("Mystery Key"));
            dialog1.AddAction(new ModifyHealthAction(12));
            dialog1.SetText("<Accept Mystery Key>");
            string dialog1Str = SerializationUtil.Serialize<Dialog>(dialog1);
            Console.WriteLine("Dialog Serialized: ");
            Console.WriteLine(dialog1Str);

            Dialog dialog2 = SerializationUtil.Deserialize<Dialog>(dialog1Str);
            dialog2.SetText("<Accept Deserialized Key>");
            Console.WriteLine("\nDialog Deserialized then Serialized again: ");
            Console.WriteLine(SerializationUtil.Serialize(dialog2));

            Console.WriteLine("\nExecuting dialog actions:");
            dialog2.ExecuteActions();
        }
        */
    }
}
