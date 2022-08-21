using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    [HideInInspector]
    public GhostBuilding ghostBuilding = null;
    [SerializeField] StrategicCamera StrategicCamera;
    //bool placeIsValid;


    private void Update()
    {
        if (ghostBuilding == null) return;
        if (StrategicCamera.Hit.collider == null) return;

        if (ghostBuilding is GhostModule && StrategicCamera.Hit.collider.TryGetComponent<Socket>(out Socket socket))
        {
            ghostBuilding.transform.position = socket.transform.position;
            ghostBuilding.transform.rotation = socket.transform.rotation;
            //placeIsValid = true;
        }
        else
        {
            ghostBuilding.transform.position = StrategicCamera.Hit.point;
            //placeIsValid = false;
        }

        if (Input.GetMouseButtonDown(0) && ghostBuilding.PlaceIsValid)
        {
            Build();
        }

    }

    void Build()
    {
        //≈сли услови€ строительства соблюдены
        ghostBuilding.PlaceBuilding();
        ghostBuilding = null;
    }

}
