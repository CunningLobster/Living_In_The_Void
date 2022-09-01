using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Строитель. Класс отвечает за логику Строительства с помощью проекции взятой из пула 
/// </summary>
public class Builder : MonoBehaviour
{
    private GhostBuilding selectedBuilding = null;
    [SerializeField] private StrategicCamera strategicCamera;
    [SerializeField] private GhostBuildingPool ghostBuildingPool;

    private void Update()
    {
        if (selectedBuilding == null) return;
        if (strategicCamera.Hit.collider == null) return;

        selectedBuilding.ShowBuildingPoint(strategicCamera.Hit);

        //TODO: Change input
        if (Input.GetMouseButtonDown(0))
            Build();
    }

    /// <summary>
    /// Построить
    /// </summary>
    void Build()
    {    
        selectedBuilding.PlaceBuilding();
        ghostBuildingPool.HideGhostBuilding();
    }

    /// <summary>
    /// Установить значение Ghost Building
    /// </summary>
    /// <param name="ghostBuilding">Проекция здания из пула</param>
    public void SetGhostBuilding(BuildingData buildingData)
    {
        this.selectedBuilding = ghostBuildingPool.GetGhostBuilding(buildingData);
    }
}
