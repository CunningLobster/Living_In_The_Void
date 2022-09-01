using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Пул, в котором хранятся проекции построек
/// </summary>
public class GhostBuildingPool : MonoBehaviour
{
    /// <summary>
    /// Проекции построек
    /// </summary>
    [SerializeField] private List<GhostBuilding> ghostBuildings = new List<GhostBuilding>();

    /// <summary>
    /// Достать Проекцию с переданными Данными из пула и присвоить ее объекту класса Builder
    /// </summary>
    /// <param name="buildingData">Данные здания</param>
    public GhostBuilding GetGhostBuilding(BuildingData buildingData)
    {
        HideGhostBuilding();
        GhostBuilding ghostBuilding = ghostBuildings.FirstOrDefault(m => m.BuildingData.Equals(buildingData));

        ghostBuilding.gameObject.SetActive(true);

        return ghostBuilding;
    }

    /// <summary>
    /// Убрать проекцию в пул
    /// </summary>
    public void HideGhostBuilding()
    {
        foreach (GhostBuilding ghostBuilding in ghostBuildings)
            ghostBuilding.gameObject.SetActive(false);
    }
}
