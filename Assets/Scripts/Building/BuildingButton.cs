using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    [SerializeField] BuildingData buildingData;
    Builder builder;

    private void Awake()
    {
        builder = FindObjectOfType<BuildingMenu>();
    }

    public void GetGhostBuilding()
    {
        builder.SetGhostBuilding(buildingData);
    }
}
