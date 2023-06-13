using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiskDetection : MonoBehaviour
{
    public GameObject pusher;
    public string diskTag = "White Disk";
    public float speed = 1.0f;
    public Vector3 target = new Vector3 (0, 0, 0);
    private int trigger;
    private Vector3 og_loc;

    void Start()
    {
        og_loc = pusher.transform.position;
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
            pusher.transform.Translate(speed * target);
        }
        else if (trigger == -1 && pusher.transform.position == og_loc)
        {
            trigger = 0;
        }
        else if (trigger == -1)
        {
            pusher.transform.Translate(speed * target * -1);
        }

    }

}
