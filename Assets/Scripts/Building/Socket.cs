using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour, IRaycastTarget
{
    private Builder builder;

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();    
    }

    public void Respond()
    {
        if (builder.ghostBuilding != null)
        {

        }
    }


}
