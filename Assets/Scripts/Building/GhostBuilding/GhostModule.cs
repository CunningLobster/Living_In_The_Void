using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostModule : GhostBuilding
{
    public bool connected;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Socket>(out Socket socket))
            gameObject.transform.rotation = other.transform.rotation;
    }
}
