using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //The total lifepoints, if we want that something were hitten multiple times
    public float health = 50f;

    // The method called by raycast sistem.
    // So every object that has this method will take damage on certen amount
    public void TakeDamage(float amount)
    {
        // discount the damage from health
        health -= amount;
        // if something has 0 or less lifes it dies
        if (health <= 0f)
            Die();
    }

    // Destroy the object when it's dead
    void Die() {
        Destroy(gameObject);
    }
}
