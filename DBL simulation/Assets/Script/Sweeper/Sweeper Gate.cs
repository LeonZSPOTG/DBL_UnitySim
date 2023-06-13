using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Sweeper : MonoBehaviour
{
    public float speed = 3;
    public Vector3 RotDir = new Vector3(1, 0, 0);


    void Update()
    {
        if (Input.GetKey("r"))
        {
            transform.Rotate(speed * RotDir * Time.deltaTime);
        }
        if (Input.GetKey("f"))
        {
            transform.Rotate(-(speed * RotDir * Time.deltaTime));
        }
    }
}
