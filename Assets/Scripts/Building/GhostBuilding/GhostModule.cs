using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostModule : GhostBuilding
{
    [SerializeField] private Socket socket;

    private void OnDisable()
    {
        socket = null;
        placeIsValid = false;
    }

    public void Connect(Socket socket)
    {
        this.socket = socket;
    }

    public void Disconnect()
    {
        socket = null;
    }

    private void Update()
    {

        if (socket == null)
            placeIsValid = false;
        else
            placeIsValid = true;

        //Debug.Log("Module pos: " + transform.position);
        //Debug.Log("Socket pos: " + socket.transform.position);

    }
}
