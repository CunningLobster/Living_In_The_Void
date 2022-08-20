using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GhostBuildingPool : MonoBehaviour
{
    [SerializeField] List<GhostBuilding> ghostBuildings = new List<GhostBuilding>();
    Builder builder;

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();
    }

    public void GetGhostBuilding()
    {
        GhostBuilding ghostBuilding = ghostBuildings.FirstOrDefault<GhostBuilding>(m => m.gameObject.activeInHierarchy == false);
        ghostBuilding.gameObject.SetActive(true);
        builder.ghostBuilding = ghostBuilding;
    }
}
