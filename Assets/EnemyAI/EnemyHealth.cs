using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(int _damage)
    {
        currentHealth -= _damage;
        animator.SetTrigger("isHit");

        if(currentHealth<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
