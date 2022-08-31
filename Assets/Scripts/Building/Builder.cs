using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������. ����� �������� �� ������ ��������� ������, � ������� �������� ������ �� ���� 
/// </summary>
public class Builder : MonoBehaviour
{
    /// <summary>
    /// �������� ������, ������ �� ����
    /// </summary>
    private GhostBuilding ghostBuilding = null;
    /// <summary>
    /// �������������� ������
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
    /// ���������
    /// </summary>
    void Build()
    {    
        ghostBuilding.PlaceBuilding();
        ghostBuildingPool.HideGhostBuilding();
    }

    /// <summary>
    /// ���������� �������� Ghost Building
    /// </summary>
    /// <param name="ghostBuilding">�������� ������ �� ����</param>
    public void SetGhostBuilding(BuildingData buildingData)
    {
        this.ghostBuilding = ghostBuildingPool.GetGhostBuilding(buildingData);
    }
}
