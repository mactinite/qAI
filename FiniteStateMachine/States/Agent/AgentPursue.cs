using UnityEngine;
using UnityEngine.AI;
using XNode;
using QAI.FSM;
[CreateNodeMenu("FSM/State/Agent/Pursue")]
class AgentPursue : FSMStateNode
{
    [Input] public BlackboardVector3 agentDestination;
    private NavMeshAgent agent;

    protected override void Init()
    {
        base.Init();        
    }
    public override void Enter()
    {
        GameObject go = FSM.GetValue<GameObject>("GameObject");
        agent = go.GetComponent<NavMeshAgent>();
        agent.isStopped = false;
    }

    public override void Exit()
    {
        agent.isStopped = true;
    }
    public override void Run()
    {
        Vector3 dest = (Vector3)agentDestination.GetValue();
        agent.SetDestination(dest);
    }
}