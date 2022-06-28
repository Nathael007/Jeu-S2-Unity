using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Intel : MonoBehaviour
{

    public Transform player;
    public NavMeshAgent agent;
    public float distance;
    Animator Zombie;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Zombie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, agent.transform.position);

        if (distance <= 5.5 && distance > 1)
        {
            Zombie.SetFloat("marcher", 1);
            agent.SetDestination(player.transform.position);
        }
        else if (!Input.GetKey(KeyCode.C) && distance <= 5.5 && distance > 1)
        {

            agent.SetDestination(player.transform.position);
        }
        else if (distance > 5.5)
        {
            Zombie.SetFloat("marcher", 0);
        }


    }
}
