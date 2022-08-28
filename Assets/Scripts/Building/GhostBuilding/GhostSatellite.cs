using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSatellite : GhostBuilding
{
    private bool isOnSurface;
    private bool isTouchingObjects;

    private void OnTriggerStay(Collider other)
    {
        if (other.isTrigger) return;
        isTouchingObjects = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.isTrigger) return;
        isTouchingObjects = false;
    }

    private void Update()
    {
        placeIsValid = isOnSurface && !isTouchingObjects;
    }

    public override void ShowBuildingPoint(RaycastHit hit)
    {
        transform.position = hit.point;
    }

    public void SetIsOnSurface(bool isOnSurface)
    {
        this.isOnSurface = isOnSurface;
    }

}
