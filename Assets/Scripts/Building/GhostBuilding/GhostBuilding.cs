using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� ���������
/// </summary>
public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    [SerializeField] private Building buildingPrefab;
    protected bool placeIsValid;

    /// <summary>
    /// ������ ���������
    /// </summary>
    public BuildingData BuildingData => buildingData;

    private void OnDisable()
    {
        placeIsValid = false;
    }

    /// <summary>
    /// ���������� �������� �� �������������� ����� ���������
    /// </summary>
    /// <param name="hit">������ ����� ����������� �������� �� ������ �� ��������� ����</param>
    abstract public void ShowBuildingPoint(RaycastHit hit);

    /// <summary>
    /// ���������� ���������
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
