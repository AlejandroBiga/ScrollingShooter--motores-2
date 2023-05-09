using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicBullte : MonoBehaviour
{
    public Transform spawnPosition;

    public GameObject bulletPrefab;

    public float bulletForce;

    public float bulletLifetime = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {







            GameObject bulletClone = Instantiate(bulletPrefab, spawnPosition.position, spawnPosition.rotation);



            Rigidbody rb = bulletClone.GetComponent<Rigidbody>();



            rb.AddRelativeForce(Vector3.up * bulletForce, ForceMode.Impulse);

            Destroy(bulletClone, bulletLifetime);




        }
    }
}
