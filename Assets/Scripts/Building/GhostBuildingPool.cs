using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// ���, � ������� �������� �������� ��������
/// </summary>
public class GhostBuildingPool : MonoBehaviour
{
    /// <summary>
    /// �������� ��������
    /// </summary>
    [SerializeField] private List<GhostBuilding> ghostBuildings = new List<GhostBuilding>();

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();
    }

    /// <summary>
    /// ������� �������� � ����������� ������� �� ���� � ��������� �� ������� ������ Builder
    /// </summary>
    /// <param name="buildingData">������ ������</param>
    public GhostBuilding GetGhostBuilding(BuildingData buildingData)
    {
        HideGhostBuilding();
        GhostBuilding ghostBuilding = ghostBuildings.FirstOrDefault(m => m.BuildingData.Equals(buildingData));

        if (ghostBuilding == null) return;
        ghostBuilding.gameObject.SetActive(true);

        return ghostBuilding;
    }

    /// <summary>
    /// ������ �������� � ���
    /// </summary>
    public void HideGhostBuilding()
    {
        foreach (GhostBuilding ghostBuilding in ghostBuildings)
            ghostBuilding.gameObject.SetActive(false);
    }
}
