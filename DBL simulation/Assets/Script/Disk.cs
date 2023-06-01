using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disk : MonoBehaviour
{
    public LayerMask conveyorLayer;
    public float raycastDistance;
    public ConveyorBelt conveyorBelt;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, conveyorLayer))
        {
            conveyorBelt = hit.collider.gameObject.GetComponent<ConveyorBelt>();
        }

        if (conveyorBelt) 
        {
            rb.MovePosition(transform.position + conveyorBelt.direction * conveyorBelt.speed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * raycastDistance);
    }
}
