using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������������� ������. �������� �� �������� ������ � ���������� �������� � ����� ��������� ����
/// </summary>
public class StrategicCamera : MonoBehaviour
{
    private RaycastHit hit;

    /// <summary>
    /// ������ ����� ����������� ���� � �������
    /// </summary>
    public RaycastHit Hit => hit;

    void Update()
    {
        if (!CameraRaycast(out hit)) return;
        CameraRaycast(out hit);
    }

    /// <summary>
    /// ������� � ������� ����, ���������� �� ������ � ������������� �� ������ ����
    /// </summary>
    /// <param name="hit">������ ����� ����������� ���� � �������</param>
    /// <returns>true, ���� � ����� ����������� ���� ������ � �����������</returns>
    bool CameraRaycast(out RaycastHit hit)
    {
        Vector3 origin = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height / 2));
        Vector3 direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 500));

        Ray ray = new Ray(origin, direction);
        Debug.DrawRay(origin, direction, Color.blue);
        return Physics.Raycast(ray, out hit);
    }

}
