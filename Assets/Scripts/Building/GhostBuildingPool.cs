using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GhostBuildingPool : MonoBehaviour
{
    [SerializeField] private List<GhostBuilding> ghostBuildings = new List<GhostBuilding>();
    private Builder builder;

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();
    }

    public void GetGhostBuilding(BuildingData buildingData)
    {
        HideGhostBuilding();
        GhostBuilding ghostBuilding = ghostBuildings.FirstOrDefault(m => m.BuildingData.Equals(buildingData));

        if (ghostBuilding == null) return;
        ghostBuilding.gameObject.SetActive(true);
        builder.SetGhostBuilding(ghostBuilding);
    }

    public void HideGhostBuilding()
    {
        foreach (GhostBuilding ghostBuilding in ghostBuildings)
        { 
            ghostBuilding.gameObject.SetActive(false);
        }
    }
}
