using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNode;
namespace QAI.BT.Custom
{

    /// <summary>An example task node that debugs a blackboard variable.</summary>
    [CreateNodeMenu("Modifiers/Vector3/MultiplyVector")]
    public class MultiplyVector : BlackboardModifierNode<Vector3>
    {

        [Input] public Vector3 _input;
        public float factor;


        /// <summary>Execute task.</summary>

        public override object GetValue(NodePort port)
        {
            // Only respond to value requests.
            if (port.fieldName != "_result") { return null; }
            // get input values
            Vector3 input = GetInputValue("_input", Vector3.zero);
            // Get calculated value.
            Vector3 value = input * factor;
            // Return the value.
            return value;
        }

    }
}