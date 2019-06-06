using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNode;
namespace QAI.BT.Custom
{

    /// <summary>An example task node that debugs a blackboard variable.</summary>
    [CreateNodeMenu("Modifiers/Vector3/AddVectors")]
    public class AddVectors : BlackboardModifierNode<Vector3>
    {

        [Input] public Vector3 _input;
        [Input] public Vector3 _input2;

        /// <summary>Execute task.</summary>

        public override object GetValue(NodePort port)
        {
            // Only respond to value requests.
            if (port.fieldName != "_result") { return null; }
            // get input values
            Vector3 input = GetInputValue("_input", Vector3.zero);
            Vector3 input2 = GetInputValue("_input2", Vector3.zero);
            // Get calculated value.
            Vector3 value = input + input2;
            // Return the value.
            return value;
        }

    }
}