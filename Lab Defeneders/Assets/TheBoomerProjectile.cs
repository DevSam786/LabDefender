using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheBoomerProjectile : MonoBehaviour
{
    public GameObject target;
    public GameObject enemy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != enemy)
        {
            Destroy(target);
            Destroy(gameObject);
        }      
    }
}
