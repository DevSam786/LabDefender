using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject[] leftClickBullets;
    [SerializeField] private GameObject rightClickBullet;
    [SerializeField] private float bulletForce;
    int rand;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rand = Random.Range(0, leftClickBullets.Length);
        Shoot();

    }
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject leftBullet = Instantiate(leftClickBullets[rand], spawnPoint.position, Quaternion.identity);
            Rigidbody rb = leftBullet.GetComponent<Rigidbody>();
            rb.AddForce(spawnPoint.forward * bulletForce * Time.deltaTime,ForceMode.Impulse);
        }else if (Input.GetMouseButtonDown(1))
        {
            GameObject rightBullet = Instantiate(rightClickBullet, spawnPoint.position, Quaternion.identity);
            Rigidbody rb = rightBullet.GetComponent<Rigidbody>();
            rb.AddForce(spawnPoint.forward * bulletForce * Time.deltaTime, ForceMode.Impulse);
        }


    }
}
