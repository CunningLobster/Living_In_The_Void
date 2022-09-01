using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Проекция модуля
/// </summary>
public class GhostModule : GhostBuilding
{
    public override void ShowBuildingPoint(RaycastHit hit)
    {
        //Если курсор указывает на сокет
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
