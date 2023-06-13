using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpawnerScript : MonoBehaviour
{
    public GameObject BlackDisk;
    public GameObject WhiteDisk;
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Instantiate(BlackDisk, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown("2"))
        {
            Instantiate(WhiteDisk, transform.position, Quaternion.identity);
        }
    }
}
