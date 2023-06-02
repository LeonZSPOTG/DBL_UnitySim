using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    public ConveyorBelt conveyorBelt;

    public float fixThreshold = 0.1f;
    public float fixSpeed = 2;

    private Rigidbody rb;
    private float counter;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (conveyorBelt) 
        {
            Vector3 movement = Vector3.zero;
            movement += conveyorBelt.direction * conveyorBelt.speed;

            Vector3 perpendicular = Vector3.Cross(conveyorBelt.direction, Vector3.up).normalized;
            Vector3 fix = Vector3.Project(conveyorBelt.transform.position - transform.position, perpendicular);
            if (fix.magnitude > fixThreshold)
            {
                movement += fix.normalized * fixSpeed;
                rb.MovePosition(transform.position + movement * Time.deltaTime);
            }
            else {
                rb.MovePosition(transform.position + movement * Time.deltaTime + fix);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        conveyorBelt = other.gameObject.GetComponent<ConveyorBelt>();
        counter++;
    }

    private void OnTriggerExit(Collider other)
    {
        counter--;
        if (counter <= 0)
        {
            conveyorBelt = null;
            counter = 0;
        }
    }
}
