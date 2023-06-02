using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{

    public float speed = 3;
    public Vector3 target = new Vector3(1, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")) 
        {
            transform.Translate(speed * target * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(-(speed * target * Time.deltaTime));
        }

    }
}
