using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehavior {
    public Transform goal;
    private NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.destination = goal.position;
    }
}