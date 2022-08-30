using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� ���������
/// </summary>
public abstract class GhostBuilding : MonoBehaviour
{
    [SerializeField] private BuildingData buildingData;
    /// <summary>
    /// ������ ���������
    /// </summary>
    public BuildingData BuildingData => buildingData;

    /// <summary>
    /// ������, ������� ����� �������� ��� ���������
    /// </summary>
    [SerializeField] Building buildingPrefab;


    protected bool placeIsValid;
    /// <summary>
    /// ��������� ����� ��������� 
    /// </summary>
    public bool PlaceIsValid => placeIsValid;

    private void OnDisable()
    {
        placeIsValid = false;
    }
    abstract public void ShowBuildingPoint(RaycastHit hit);

    /// <summary>
    /// ���������� ���������
    /// </summary>
    public void PlaceBuilding()
    {
        Building building = Instantiate(buildingPrefab, gameObject.transform.position, transform.rotation);

        //����� ���������� ������ � ���
        gameObject.SetActive(false);
    }
}
