using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Условная поверхность
/// </summary>
public class Surface : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Если пересекается с Проекцией Спутника
        if (other.TryGetComponent<GhostSatellite>(out GhostSatellite ghostSatellite))
            ghostSatellite.SetIsOnSurface(true);
    }

    private void OnTriggerExit(Collider other)
    {
        //Если пересекается с Проекцией Спутника
        if (other.TryGetComponent<GhostSatellite>(out GhostSatellite ghostSatellite))
            ghostSatellite.SetIsOnSurface(false);

    }
}
