using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt2 : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Disk>().conveyorBelt = null;
        }
    }
}
