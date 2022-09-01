using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������� �����������
/// </summary>
public class Surface : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //���� ������������ � ��������� ��������
        if (other.TryGetComponent<GhostSatellite>(out GhostSatellite ghostSatellite))
            ghostSatellite.SetIsOnSurface(true);
    }

    private void OnTriggerExit(Collider other)
    {
        //���� ������������ � ��������� ��������
        if (other.TryGetComponent<GhostSatellite>(out GhostSatellite ghostSatellite))
            ghostSatellite.SetIsOnSurface(false);

    }
}
