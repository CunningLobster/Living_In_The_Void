using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    public BuildingData BuildingData => buildingData;
    [SerializeField] Building buildingPrefab;
    [SerializeField] protected bool placeIsValid;
    public bool PlaceIsValid => placeIsValid;

    public void PlaceBuilding()
    {
        Building building = Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);
        gameObject.SetActive(false);
    }

    abstract public void ShowBuildingPoint(RaycastHit hit);
}
