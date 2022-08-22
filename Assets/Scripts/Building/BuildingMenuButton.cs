using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingMenuButton : MonoBehaviour
{
    [SerializeField] BuildingMenu buildingMenu;

    public void ToggleBuildindMenu()
    { 
        buildingMenu.gameObject.SetActive(!buildingMenu.gameObject.activeInHierarchy);
    }
}
