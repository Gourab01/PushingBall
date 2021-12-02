//USING Brezier Curve Algorithm FOR DETECT THE PATH

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteAssign : MonoBehaviour
{
    //Assigning Brezier Curve Algorithm
    [SerializeField]
    private Transform[] controlPoint;

    private Vector3 gizmosPosition;

    private void OnDrawGizmos()
    {
        for(float t = 0; t <= 1; t+=0.05f) 
        {
            gizmosPosition = Mathf.Pow(1 - t, 3) * controlPoint[0].position + 
                3 * Mathf.Pow(1 - t, 2) * t * controlPoint[1].position +
                3 * (1 - t) * Mathf.Pow(t, 2) * controlPoint[2].position + 
                Mathf.Pow(t, 3) * controlPoint[3].position;
            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }
        Gizmos.DrawLine(new Vector3(controlPoint[0].position.x, 0, controlPoint[0].position.z), 
            new Vector3(controlPoint[1].position.x, 0, controlPoint[1].position.z));

        Gizmos.DrawLine(new Vector3(controlPoint[2].position.x, 0, controlPoint[2].position.z),
            new Vector3(controlPoint[3].position.x, 0, controlPoint[3].position.z));
    }
}
