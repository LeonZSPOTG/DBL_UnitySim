using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    private Vector3 gizmoOffset = new Vector3(0, 1, 0);

    private void OnDrawGizmos()
    {
        DrawArrow.ForGizmo(gameObject.transform.position + gizmoOffset, direction, Color.red);
    }

}
