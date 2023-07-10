using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// All entities that can take damage must use the interface
/// </summary>
public interface IDamageable
{
    void Damage(int amount);
    void Die();
}