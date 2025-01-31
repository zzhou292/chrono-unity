using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Waypoint : MonoBehaviour
{

    private Vector3 lastPosition;

    public void OnValidate() {
        if(transform.position != lastPosition) {
            lastPosition = transform.position;
            AdjustHeightToTerrain();
        }
    }
    public void AdjustHeightToTerrain()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 10f))
        {
            transform.position = new Vector3(transform.position.x, hit.point.y + 0.5f, transform.position.z);
        }
    }
}