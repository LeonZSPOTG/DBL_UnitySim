using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor2 : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Stuff(collision));
        }
    }

    private IEnumerator Stuff(Collision collision)
    {
        yield return new WaitForSeconds(1);
        collision.gameObject.GetComponent<Disk>().conveyorBelt = null;
    }
}
