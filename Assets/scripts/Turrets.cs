using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrets : MonoBehaviour
{
    [SerializeField] float turretRange = 13f;
    [SerializeField] float turretRootationSpeed = 5f;

    private Transform playerTransform;

    private void Start()
    {
        playerTransform = FindObjectOfType<LogicPlayer>().transform;
    }

    private void Update()
    {
        Vector3 playerGroundPos = new Vector3(playerTransform.position.x,
            transform.position.y, playerTransform.position.z);

        //player is in range?
        if (Vector3.Distance(transform.position, playerGroundPos) > turretRange)
        {
            return;
        }

        //rotate turret towards player
        Vector3 playerDirection= playerGroundPos - transform.position;
        float turretRotationStep = turretRootationSpeed * Time.deltaTime;
        Vector3 newLookDirection = Vector3.RotateTowards(transform.forward, playerDirection,
            turretRotationStep, 0f);
        transform.rotation = Quaternion.LookRotation(newLookDirection);

        


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, turretRange);
    }
}
