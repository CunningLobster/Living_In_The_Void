using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������. ����� �������� �� ������ ������������� � ������� �������� ������ �� ���� 
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
    /// ���������
    /// </summary>
    void Build()
    {    
        selectedBuilding.PlaceBuilding();
        ghostBuildingPool.HideGhostBuilding();
    }

    /// <summary>
    /// ���������� �������� Ghost Building
    /// </summary>
    /// <param name="ghostBuilding">�������� ������ �� ����</param>
    public void SetGhostBuilding(BuildingData buildingData)
    {
        this.selectedBuilding = ghostBuildingPool.GetGhostBuilding(buildingData);
    }
}
