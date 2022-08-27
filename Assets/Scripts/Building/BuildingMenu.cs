using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMenu : MonoBehaviour
{
    [SerializeField] private GhostBuildingPool ghostBuildingPool;
    public GhostBuildingPool GhostBuildingPool => ghostBuildingPool;
}
