using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Socket : MonoBehaviour
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
                ghostModule.Connect(this);
            }
        }
        else if (ghostModule != null)
        {
            ghostModule.Disconnect();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<GhostModule>(out GhostModule ghostModule))
            ghostModule.Disconnect();
    }
}
