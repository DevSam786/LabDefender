using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// All enemies must inherit it!
/// </summary>
public class Enemy : MonoBehaviour, IDamageable, IEnemy
{
    /// <summary>
    /// The current health of the enemy
    /// </summary>
    public int health;
    /// <summary>
    /// Maximum enemy health
    /// </summary>
    public int maxHealth = 100;
    public NavMeshAgent agent;

    /// <summary>
    /// Player
    /// </summary>
    public Player player;

    public virtual void Start()
    {
        health = maxHealth;
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Player>();
    }

    public virtual void Attack() { }

    public virtual void Damage(int amount)
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

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
