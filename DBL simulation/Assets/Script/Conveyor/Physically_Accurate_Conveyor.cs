using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physically_Accurate_Conveyor : MonoBehaviour
{
    public float speed = 5;
    public Vector3 direction = new Vector3 (1, 0, 0);
    private Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

  
    void FixedUpdate()
    {
        Vector3 pos = rBody.position;
        rBody.position += (-direction) * speed * Time.fixedDeltaTime;
        rBody.MovePosition(pos);
    }
}
