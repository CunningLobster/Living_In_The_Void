using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ModulePool : MonoBehaviour
{
    [SerializeField] List<Module> modules = new List<Module>();
    [SerializeField] Builder builder;

    public void GetModule()
    {
        var moduleToActivate = modules.FirstOrDefault<Module>(m => m.gameObject.activeInHierarchy == false);
        moduleToActivate.gameObject.SetActive(true);
        builder.SetActiveModule(moduleToActivate);
    }
}
