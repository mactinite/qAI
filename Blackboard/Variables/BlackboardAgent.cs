using System.Collections;
using System.Collections.Generic;
using QAI;
using UnityEngine;
using UnityEngine.AI;
using XNode;

/// <summary> A blackboard node for a variable of Vector3 type.</summary>
[CreateNodeMenu("Blackboard/Agent")]
public class BlackboardAgent : BlackboardVariableNode<NavMeshAgent> { }