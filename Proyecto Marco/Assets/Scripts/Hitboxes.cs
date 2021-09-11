using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitboxes : MonoBehaviour
{
    public enemyHealth health;


    public void OnRaycastHit(shootScript weapon)
    {
        health.TakeDamage(weapon.damage);
    }
}
