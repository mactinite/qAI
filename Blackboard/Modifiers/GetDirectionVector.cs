using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using XNode;
namespace QAI.BT.Custom
{

    /// <summary>An example task node that debugs a blackboard variable.</summary>
    [CreateNodeMenu("Modifiers/Vector3/GetDirectionVector")]
    public class GetDirectionVector : BlackboardModifierNode<Vector3>
    {

        [Input] public Vector3 _vectorA;
        [Input] public Vector3 _vectorB;

        public bool normalize;


        /// <summary>Execute task.</summary>

        public override object GetValue(NodePort port)
        {
            // Only respond to value requests.
            if (port.fieldName != "_result") { return null; }
            // get input values
            Vector3 a = GetInputValue("_vectorA", Vector3.zero);
            Vector3 b = GetInputValue("_vectorB", Vector3.zero);
            // Get calculated value.
            Vector3 value = a - b;
            if(normalize) value.Normalize();
            // Return the value.
            return value;
        }

    }
}