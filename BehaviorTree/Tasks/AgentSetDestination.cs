using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;
using QAI.BT;
using XNode;

/// <summary>An example task node that debugs a blackboard variable.</summary>
[CreateNodeMenu("BT/Action/AgentSetDestination")]
public class AgentSetDestination : BTTaskNode
{
    [Input] public BlackboardVector3 _destination;
    // Execute task
    protected override BTGraphResult InternalRun()
    {
        // Get agent from blackboard.
        NavMeshAgent agent = BT.GetValue<NavMeshAgent>("Agent");
        if (agent == null) { return BTGraphResult.Failure; }

        Vector3 destination = GetInputValue("_destination", Vector3.zero);
        agent.SetDestination(destination);
        return BTGraphResult.Success;
    }
}