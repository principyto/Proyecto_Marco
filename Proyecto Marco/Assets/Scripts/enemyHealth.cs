using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float maxHealth = 10;
    float currentHealth;
    Ragdoll ragdoll;

    void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
        currentHealth = maxHealth;

        var rigidBodies = GetComponentsInChildren<Rigidbody>();
        foreach(var rigidBody in rigidBodies)
        {
            Hitboxes hitbox = rigidBody.gameObject.AddComponent<Hitboxes>();
            hitbox.health = this;
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ragdoll.ActivateRagdoll();
    }

}
