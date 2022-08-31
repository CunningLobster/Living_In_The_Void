using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Строитель. Класс отвечает за логику постройки здания, с помощью проекции взятой из пула 
/// </summary>
public class Builder : MonoBehaviour
{
    /// <summary>
    /// Проекция здания, взятая из пула
    /// </summary>
    private GhostBuilding ghostBuilding = null;
    /// <summary>
    /// Стратегическая камера
    /// </summary>
    [SerializeField] private StrategicCamera strategicCamera;

    [SerializeField] private GhostBuildingPool ghostBuildingPool;

    private void Update()
    {
        if (ghostBuilding == null) return;
        if (strategicCamera.Hit.collider == null) return;

        ghostBuilding.ShowBuildingPoint(strategicCamera.Hit);

        //TODO: Change input
        if (Input.GetMouseButtonDown(0) && ghostBuilding.PlaceIsValid)
        {
            Build();
        }
    }

    /// <summary>
    /// Построить
    /// </summary>
    void Build()
    {    
        ghostBuilding.PlaceBuilding();
        ghostBuildingPool.HideGhostBuilding();
    }

    /// <summary>
    /// Установить значение Ghost Building
    /// </summary>
    /// <param name="ghostBuilding">Проекция здания из пула</param>
    public void SetGhostBuilding(BuildingData buildingData)
    {
        this.ghostBuilding = ghostBuildingPool.GetGhostBuilding(buildingData);
    }
}
