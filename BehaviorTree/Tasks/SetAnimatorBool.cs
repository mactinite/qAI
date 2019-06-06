using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using QAI.BT;


/// <summary>An example task node that debugs a blackboard variable.</summary>
[CreateNodeMenu("BT/Action/SetAnimatorBool")]
public class SetAnimatorBool : BTTaskNode
{
    [Input] public bool _value;
    [Input] public string _key;
    // Execute task
    protected override BTGraphResult InternalRun()
    {
        // Get animator from black board
        Animator anim = BT.GetValue<Animator>("Animator");

        string key = GetInputValue<string>("_key", null);
		bool value = GetInputValue<bool>("_value", false);
		if(key== null){
			key = _key;
			value = _value;
		}

		if(anim == null || key == null){
			return BTGraphResult.Failure;
		}

		anim.SetBool(key,value);		
        // Return success.
        return BTGraphResult.Success;
    }
}