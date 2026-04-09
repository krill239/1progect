using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal;

public class iispider : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Vector3 randomDirection;
    private float changeDirectionTimer;
    private float minChange = 10f;
    private float maxChange = 20f;
    float health = 27f;
    public Animator spider;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ChangeDirection();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= 10f)
        {
            agent.SetDestination(player.position);
        }
        else
        {
            changeDirectionTimer -= Time.deltaTime;
            if(changeDirectionTimer<=0f)
            {
                ChangeDirection();
            }
            agent.SetDestination(transform.position + randomDirection);
        }
    }

    void ChangeDirection()
    {
        randomDirection = Random.insideUnitSphere * 10f;
        changeDirectionTimer = Random.Range(minChange, maxChange);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnCollisionEnter");
        if (other.gameObject.CompareTag("Player"))
        {
            spider.SetTrigger("attack");
        }
    }
}
