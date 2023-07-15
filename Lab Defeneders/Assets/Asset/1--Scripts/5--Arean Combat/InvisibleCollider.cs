using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleCollider : MonoBehaviour
{
    public GameObject wallColliders;//invisible collider to not change the room
    public Arena arena;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Collider is on");
            arena.invisibleTriggered = true;
            wallColliders.SetActive(true);
        }
    }
}
