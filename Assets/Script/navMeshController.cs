using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
[RequireComponent(typeof(NavMeshAgent))]
public class navMeshController : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent agent;
    public Transform target;
    public Transform home;
    public Animator animator;
    public float minimumDistance = 10f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Vector3.Distance(target.position, target.position) < minimumDistance)
        //{
        //    agent.SetDestination(target.position);
        //}
        //else
        //{
        //    agent.SetDestination(home.position);
        //}
        //agent.SetDestination(target.position);
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    public void SetDestination(Vector3 position)
    {
        agent.SetDestination(position);
    }
}
