using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ModulePool : MonoBehaviour
{
    [SerializeField] List<Module> modules = new List<Module>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetModule()
    {
        var moduleToActivate = modules.FirstOrDefault<Module>(m => m.gameObject.activeInHierarchy == false);
        moduleToActivate.gameObject.SetActive(true);
    }
}
