using UnityEngine;
using UnityEngine.AI;
public class MoveTo : MonoBehaviour {
    public Transform goal;
    private NavMeshAgent agent;
    private Animator anim;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        agent.destination = goal.position;
    }
}
