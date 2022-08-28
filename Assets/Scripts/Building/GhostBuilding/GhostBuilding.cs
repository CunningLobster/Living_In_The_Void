using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    public BuildingData BuildingData => buildingData;
    [SerializeField] Building buildingPrefab;
    protected bool placeIsValid;
    public bool PlaceIsValid => placeIsValid;

    private void OnDisable()
    {
        placeIsValid = false;
    }
    abstract public void ShowBuildingPoint(RaycastHit hit);

    public void PlaceBuilding()
    {
        Building building = Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
}
