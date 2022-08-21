using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour, IRaycastTarget
{
    private Builder builder;
    [SerializeField]private bool connected;
    public bool Connected => connected;

    private void Awake()
    {
        builder = FindObjectOfType<Builder>();    
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<GhostModule>(out GhostModule ghostModule))
        {
            if (ghostModule.transform.position == transform.position)
            {
                Debug.Log(Vector3.Distance(ghostModule.transform.position, gameObject.transform.position));
                //ghostModule.transform.rotation = gameObject.transform.rotation;
                //connected = true;
                ghostModule.Connect(this);
            }
        }
        else if (ghostModule != null)
        {
            //connected = false;
            //ghostModule = null;
            ghostModule.Disconnect();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<GhostModule>(out GhostModule ghostModule))
            ghostModule.Disconnect();
            //connected = false;
    }

    public void Respond()
    {
    }
}
