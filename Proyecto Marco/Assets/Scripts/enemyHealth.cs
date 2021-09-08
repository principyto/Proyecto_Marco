using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float health;
    Ragdoll ragdoll;

    void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
        health = 10;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ragdoll.ActivateRagdoll();
    }

}
