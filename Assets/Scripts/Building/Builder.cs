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
        Building building = selectedBuilding.PlaceBuilding();
        if(building != null)
            ghostBuildingPool.HideGhostBuilding();
    }

    /// <summary>
    /// ���������� �������� Ghost Building
    /// </summary>
    /// <param name="ghostBuilding">�������� ������ �� ����</param>
    public void SelectBuilding(BuildingData buildingData)
    {
        this.selectedBuilding = ghostBuildingPool.GetGhostBuilding(buildingData);
    }
}
