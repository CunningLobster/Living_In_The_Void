using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
{
    public Module module;

    private void OnTriggerStay(Collider other)
    {
        if (!other.TryGetComponent<Module>(out Module module)) return;
        this.module = module;
        module.PluggedIn = true;
        module.transform.position = gameObject.transform.position;
    }

    private void OnTriggerExit(Collider other)
    {
        module.PluggedIn = false;
    }
}
