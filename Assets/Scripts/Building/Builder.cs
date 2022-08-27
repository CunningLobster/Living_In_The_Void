using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    private GhostBuilding ghostBuilding = null;
    [SerializeField] StrategicCamera strategicCamera;

    private void Update()
    {
        if (ghostBuilding == null) return;
        if (strategicCamera.Hit.collider == null) return;

        ghostBuilding.ShowBuildingPoint(strategicCamera.Hit);

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

    public void SetGhostBuilding(GhostBuilding ghostBuilding)
    { 
        this.ghostBuilding = ghostBuilding;
    }
}
