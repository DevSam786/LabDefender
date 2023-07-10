using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour, IDamageable
{
    /// <summary>
    /// The current health of the player
    /// </summary>
    public int health;
    /// <summary>
    /// Maximum player health
    /// </summary>
    public int maxHealth = 100;

    public void Damage(int amount)
    {
        if (health > 0)
        {
            health -= amount;
        }
        else
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
