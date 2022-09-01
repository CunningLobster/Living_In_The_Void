using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingButton : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    private Builder builder;

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();
    }

    public void SelectBuilding()
    {
        builder.SelectBuilding(buildingData);
    }
}
