using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TestSerialization
{
    [KnownType("_GetKnownDialogTypes")]
    [DataContract]
    class Dialog
    {
        [DataMember]
        private string text;
        [DataMember]
        private List<ICondition> conditions = new List<ICondition>();
        [DataMember]
        private List<IAction> actions = new List<IAction>();

        public Dialog() { }
        public Dialog(string text, List<ICondition> conditions, List<IAction> actions)
        {
            this.text = text;
            this.conditions = conditions;
            this.actions = actions;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void AddAction(IAction action)
        {
            actions.Add(action);
        }

        public void ExecuteActions()
        {
            foreach(IAction a in actions)
            {
                a.Execute();
            }
        }

        private static List<Type> _GetKnownDialogTypes()
        {
            return KnownTypeUtil.GetKnownDialogTypes();
        }
    }
}
