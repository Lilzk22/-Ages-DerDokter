using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class EnemyChase : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private Animator myAnimator;
    public AudioClip HitSound;

    public AudioClip ChaseSound;
    public AudioSource audioSource;

    public Transform target;

    public bool chaseTarget = true;
    public float stopingDistance = 2.5f;
    public float delayBetweenAttacks = 1.5f;  

    private float attackCooldown;
    private float distanceFromTarget;
   
    public int damage = 50;
    private Player_Health playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
        myAgent.stoppingDistance = stopingDistance;
        attackCooldown = Time.time;

        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Health>();
    }

    // Update is called once per frame
    void Update()
    {
        ChaseTarget();
    }

    void ChaseTarget()
    {
        distanceFromTarget = Vector3.Distance(target.position, transform.position);
       if(distanceFromTarget>=stopingDistance)
       {
            chaseTarget = true;
            
       }
       else
       {
            chaseTarget = false;
            Attack();
       }

       if(chaseTarget)
       {
            myAgent.SetDestination(target.position);
            myAnimator.SetBool("isChasing",true);
       }
       else
       {
            myAnimator.SetBool("isChasing",false);
       }
    }

    void Attack()
    {
        if (Time.time > attackCooldown)
        {
            playerHealth.TakeDamage(damage);
            myAnimator.SetTrigger("Attack");
            attackCooldown = Time.time + delayBetweenAttacks;

        }
    }
}
