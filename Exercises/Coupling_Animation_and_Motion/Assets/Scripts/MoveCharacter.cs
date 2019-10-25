using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveCharacter : MonoBehaviour
{
    Animator animator;
    NavMeshAgent nav_mesh_agent;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        nav_mesh_agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nav_mesh_agent.remainingDistance > 0.0f)
            animator.SetBool("move", true);
        else
            animator.SetBool("move", false);
    }
}
