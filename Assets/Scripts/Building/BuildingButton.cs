using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    [SerializeField] GhostBuilding building;
    BuildingMenu buildingMenu;

    private void Awake()
    {
        buildingMenu = GetComponentInParent<BuildingMenu>();
    }


}
