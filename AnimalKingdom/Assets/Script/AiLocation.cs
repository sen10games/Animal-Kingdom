using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiLocation : MonoBehaviour
{
    public Transform PlayerTransform;
    public float maxTime = 1.0f;
    public float maxDistance = 1.0f;
    NavMeshAgent agent;
    Animator animator;
    float timer = 0.0f;
    
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        animator= GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {   timer -= Time.deltaTime;
        if (timer <0.0f)
        {
            float sqDistance = (PlayerTransform.position - agent.destination).sqrMagnitude;
            if (sqDistance > maxDistance*maxDistance)
            {
                agent.destination= PlayerTransform.position;
            }
            timer = maxTime;
        }
       
        animator.SetFloat("speed",agent.velocity.magnitude);
    }
}
