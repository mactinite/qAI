using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace QAI.FSM.Custom
{

    /// <summary>A node for checking if a blackboard variable is null.</summary>
    [CreateNodeMenu("FSM/Check/InRange")]
    public class InRangeCheck : FSMCheckNode
    {

        public float range = 5;

        /// <summary>Initialize node for execution.</summary>
        protected override void Init()
        {
            _expectedType = typeof(BlackboardVector3);
            base.Init();
        }

        /// <summary>Execute the check.</summary>
        protected override bool InternalCheck()
        {
            // Check if variable is null.
            Vector3 variable = GetBlackboardValue<Vector3>("_variable", _variable);
            GameObject go = FSM.GetValue<GameObject>("GameObject");
            return Vector3.Distance(variable, go.transform.position) < range;
        }
    }
}