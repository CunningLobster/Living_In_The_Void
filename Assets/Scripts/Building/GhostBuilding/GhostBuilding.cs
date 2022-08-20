using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] Building buildingPrefab;

    public void PlaceBuilding()
    { 
        Building building = Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);
        gameObject.SetActive(false);
    }
}
