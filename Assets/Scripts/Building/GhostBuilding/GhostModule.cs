using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostModule : GhostBuilding
{
    private void OnDisable()
    {
        placeIsValid = false;
    }

    public override void ShowBuildingPoint(RaycastHit hit)
    {
        if (hit.collider.TryGetComponent<Socket>(out Socket socket))
        {
            transform.position = socket.transform.position;
            transform.rotation = socket.transform.rotation;
            placeIsValid = true;
        }
        else
        {
            placeIsValid = false;
            transform.position = hit.point;
        }
    }
}
