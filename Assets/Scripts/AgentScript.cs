using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //1
 
public class AgentScript : MonoBehaviour
{
    public Animator animator; //2
    NavMeshAgent agent;  //4
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        animator.SetFloat("Speed_f", agent.velocity.magnitude);


    }
}
