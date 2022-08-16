using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour, IRaycastTarget
{
    public Module module;

    //private void OnTriggerStay(Collider other)
    //{
    //    if (!other.TryGetComponent<Module>(out Module module)) return;
    //    this.module = module;
    //    module.PluggedIn = true;
    //    module.transform.position = gameObject.transform.position;
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    module.PluggedIn = false;
    //}

    public void Respond()
    {
        Debug.Log("Socket Responded");
    }
}
