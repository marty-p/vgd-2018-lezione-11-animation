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
        // magnitude goes between 0 and speed
        // speed is the max velocity
        // velocity is a vector3d of how fast the agent is currently going
        agent.destination = goal.position;
        // check if agent is moving
        if (agent.velocity.magnitude > 0)
            anim.SetBool("isMoving", true);
        else
            anim.SetBool("isMoving", false);
        // set velocity
        anim.SetFloat("Velocity", agent.velocity.magnitude / agent.speed);
    }
}
