using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSatellite : GhostBuilding
{
    private void OnEnable()
    {
        placeIsValid = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other != null)
            placeIsValid = false;
        else
            placeIsValid = true;
    }
}
