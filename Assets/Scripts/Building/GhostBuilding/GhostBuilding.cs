using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Проекция постройки
/// </summary>
public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    /// <summary>
    /// Данные постройки
    /// </summary>
    public BuildingData BuildingData => buildingData;

    /// <summary>
    /// Префаб, который будет размещен при постройке
    /// </summary>
    [SerializeField] Building buildingPrefab;


    protected bool placeIsValid;
    /// <summary>
    /// Валидация места постройки 
    /// </summary>
    public bool PlaceIsValid => placeIsValid;

    private void OnDisable()
    {
        placeIsValid = false;
    }
    abstract public void ShowBuildingPoint(RaycastHit hit);

    /// <summary>
    /// Разместить постройку
    /// </summary>
    public void PlaceBuilding()
    {
        Building building = Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);

        //После размещения убрать в пул
        gameObject.SetActive(false);
    }
}
