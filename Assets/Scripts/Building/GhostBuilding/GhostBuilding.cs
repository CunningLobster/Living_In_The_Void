using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Проекция постройки
/// </summary>
public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    [SerializeField] private Building buildingPrefab;
    protected bool placeIsValid;

    /// <summary>
    /// Данные постройки
    /// </summary>
    public BuildingData BuildingData => buildingData;

    private void OnDisable()
    {
        placeIsValid = false;
    }

    /// <summary>
    /// Отобразить проекцию на предполагаемом месте постройки
    /// </summary>
    /// <param name="hit">Данные точки пересечения рэйкаста от камеры до указателя мыши</param>
    abstract public void ShowBuildingPoint(RaycastHit hit);

    /// <summary>
    /// Разместить постройку
    /// </summary>
    public Building PlaceBuilding()
    {
        if(IsValidToBuild())
          return Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);
        return null;
    }

    private bool IsValidToBuild()
    {
        return placeIsValid;
    }
}
