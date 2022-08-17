using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleButton : MonoBehaviour,  IRaycastTarget
{
    [SerializeField] ModulePool pool;

    public void Respond(Vector3 position)
    {
        Debug.Log("Module button responded");
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
