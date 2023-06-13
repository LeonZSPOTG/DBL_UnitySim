using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiskDetectionSweeper : MonoBehaviour
{
    public GameObject sweeper;
    string diskTag = "White Disk";
    public float speed = 1.0f;
    public Vector3 RotDirection = new Vector3(0, 0, 0);
    private int trigger;
    private Quaternion og_rot;

    void Start()
    {
        og_rot = sweeper.transform.rotation;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == diskTag)
        {
            trigger = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == diskTag)
        {
            trigger = -1;
        }

    }



    private void Update()
    {
        if (trigger == 1)
        {
            sweeper.transform.Rotate(speed * RotDirection);
        }
        else if (trigger == -1 && sweeper.transform.rotation == og_rot)
        {
            trigger = 0;
        }
        else if (trigger == -1)
        {
            sweeper.transform.Rotate(speed * RotDirection * -1);
        }

    }

}
