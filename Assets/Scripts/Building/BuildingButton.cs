using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    [SerializeField] BuildingData buildingData;
    BuildingMenu buildingMenu;

    private void Awake()
    {
        buildingMenu = GetComponentInParent<BuildingMenu>();
    }

    public void GetGhostBuilding()
    { 
        buildingMenu.GhostBuildingPool.GetGhostBuilding(buildingData);
    }
}
